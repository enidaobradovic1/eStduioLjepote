using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Klijent = eStudioLjepote.WebAPI.Database1.Klijent;

namespace eStudioLjepote.WebAPI.Services_
{
  
    public class KlijentiService : BaseCRUDService<Model.Klijent,KlijentiSearchRequest,Klijent,KlijentiUpsertRequest,KlijentiUpsertRequest>
    {
        public KlijentiService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
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
        public  Model.Klijent Authenticiraj(string username, string password)
        {

            var user = _context.Klijent.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PaswordHash)
                {
                    return _mapper.Map<Model.Klijent>(user);
                }
            }

            return null;
        }

        public override List<Model.Klijent> Get(KlijentiSearchRequest search)
        {

            var query = _context.Klijent.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Klijent>>(list);
        }

        public override Model.Klijent GetById(int id)
        {
            var entity = _context.Klijent.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<Model.Klijent>(entity);
        }

        public override Model.Klijent Insert(KlijentiUpsertRequest Request)
        {
            var entity = _mapper.Map<Database1.Klijent>(Request);

            if (Request.Password != Request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne slazu");
            }
            entity.PasswordSalt =GenerateSalt();
            entity.PaswordHash = GenerateHash(entity.PasswordSalt, Request.Password);
            _context.Klijent.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }

        public override Model.Klijent Update(int id, KlijentiUpsertRequest Request)
        {
            var entity = _context.Klijent.Find(id);
            _context.Klijent.Attach(entity);
            _context.Klijent.Update(entity);
            _context.SaveChanges();

            _mapper.Map(Request, entity);
            return _mapper.Map<Model.Klijent>(entity);
        }
    }
}
