using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class OcjeneService : BaseCRUDService<Model.Ocjene, OcjeneSearchRequest, Database1.Ratings, OcjeneUpsertRequest, OcjeneUpsertRequest>
    {
        public OcjeneService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _context.Ratings.AsQueryable();
         
            query = query.Where(x => x.KlijentId == search.KlijentId && x.UslugeId==search.UslugeId);

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjene>>(list);

        }
    }
}
