using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvod, ProizvodSearchRequest, Proizvods, ProizvodUpsertRequest, ProizvodUpsertRequest>
    {
        public ProizvodiService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Proizvod> Get(ProizvodSearchRequest search)
        {
            var query = _context.Set<Proizvods>().AsQueryable();

            if (search?.VrstaProizvodaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaProizvodaId == search.VrstaProizvodaId);
            }

            query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }
    }
}

