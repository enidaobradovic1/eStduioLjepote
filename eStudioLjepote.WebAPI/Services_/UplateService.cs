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
    public class UplateService : BaseCRUDService<Model.Uplate, UplateSearchRequest, Database1.Uplate, UplateUpsertRequest, UplateUpsertRequest>
    {
        public UplateService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Uplate> Get(UplateSearchRequest search)
        {
            var query = _context.Set<Database1.Uplate>().AsQueryable();


            if (!string.IsNullOrWhiteSpace(search?.Godina))
            {
                query = query.Where(x => x.DatumUplate.Year.ToString() == search.Godina);
            }
            if (!string.IsNullOrWhiteSpace(search?.Mjesec))
            {
                query = query.Where(x => x.DatumUplate.Month.ToString() == search.Mjesec);
            }
            if (!string.IsNullOrWhiteSpace(search?.Dan))
            {
                query = query.Where(x => x.DatumUplate.Day.ToString() == search.Dan);
            }



            var list = query.ToList();

            return _mapper.Map<List<Model.Uplate>>(list);
        }
    }
}
