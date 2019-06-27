using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using Microsoft.EntityFrameworkCore;

namespace eStudioLjepote.WebAPI.Services_
{
    public class ZaposleniciService : IZaposleniciService
    {
        private readonly _150023Context context;
        private readonly IMapper _mapper;
      

        public ZaposleniciService(_150023Context context, IMapper mapper) 
        {
            this.context = context;
            _mapper = mapper;
        }


        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Zaposlenik GetById(int id)
        {
            var entity = context.Zaposlenik.Include("ZaposleniciUloge.Uloga").FirstOrDefault(x=>x.Id==id);
            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        public List<Model.Zaposlenik> Get(ZaposleniciSearchRequest request)
        {
            var query = context.Zaposlenik.AsQueryable();
            if(!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Zaposlenik>>(list);
        }

       

        public Model.Zaposlenik Insert(ZaposleniciInsertRequest zaposleniciInsertRequest)
        {
            var entity = _mapper.Map<Database1.Zaposlenik>(zaposleniciInsertRequest);

            if(zaposleniciInsertRequest.Password!=zaposleniciInsertRequest.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne slazu");
            }
            
            entity.PasswordSalt = GenerateSalt();
            entity.PaswordHash = GenerateHash(entity.PasswordSalt,zaposleniciInsertRequest.Password);
            context.Zaposlenik.Add(entity);
            context.SaveChanges();
            foreach(var uloga in zaposleniciInsertRequest.Uloge)
            {
                Database1.ZaposleniciUloge zaposleniciUloge = new Database1.ZaposleniciUloge();
                zaposleniciUloge.ZaposlenikId = entity.Id;
                zaposleniciUloge.UlogaId = uloga;

                context.ZaposleniciUloge.Add(zaposleniciUloge);
            }
            context.SaveChanges();
            return _mapper.Map<Model.Zaposlenik>(entity);
                
        }

        public Model.Zaposlenik Update(int id, ZaposleniciInsertRequest zaposleniciInsertRequest)
        {
            var entity = context.Zaposlenik.Find(id);
            context.Zaposlenik.Attach(entity);
            context.Zaposlenik.Update(entity);
            context.SaveChanges();

            _mapper.Map(zaposleniciInsertRequest, entity);
            var zpUloge = context.ZaposleniciUloge.Where(x => x.ZaposlenikId == entity.Id).ToList();
            foreach(var uloga in zpUloge)
            {
                context.ZaposleniciUloge.Remove(uloga);
            }
            context.SaveChanges();
            foreach (var uloga in zaposleniciInsertRequest.Uloge)
            {
                Database1.ZaposleniciUloge zaposleniciUloge = new Database1.ZaposleniciUloge();
                zaposleniciUloge.ZaposlenikId = entity.Id;
                zaposleniciUloge.UlogaId = uloga;

                context.ZaposleniciUloge.Add(zaposleniciUloge);
            }
            context.SaveChanges();

            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        public Model.Zaposlenik Authenticiraj(string username, string password)
        {
           
            var user = context.Zaposlenik.Include("ZaposleniciUloge.Uloga").FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PaswordHash)
                {
                    return _mapper.Map<Model.Zaposlenik>(user);
                }
            }

            return null;
        }
    }
}
