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
    public class PlataService : BaseCRUDService<Model.Plata, PlataSearchRequest, Database1.Plata, PlataUpsertRequest, PlataUpsertRequest>
    {
        public PlataService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Plata> Get(PlataSearchRequest search)
        {
            var query = _context.Set<Database1.Plata>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Godina))
            {
                query = query.Where(x => x.Godina.ToString() == search.Godina);
            }
            if (!string.IsNullOrWhiteSpace(search?.Mjesec))
            {
                query = query.Where(x => x.Mjesec.ToString() == search.Mjesec);
            }
        





            var list = query.ToList();
            return _mapper.Map<List<Model.Plata>>(list);


        }
    }
}
