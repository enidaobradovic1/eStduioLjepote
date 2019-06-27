using AutoMapper;
using eStudioLjepote.WebAPI.Database1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class BaseService<TModel, TSearch,TDatabase> : IService<TModel, TSearch> where TDatabase:class
    {
        protected readonly _150023Context _context;
        protected readonly IMapper _mapper;

        public BaseService(_150023Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);

        }

        public void Remove(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();

        }
    }
}
