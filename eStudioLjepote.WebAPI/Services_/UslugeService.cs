using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;

namespace eStudioLjepote.WebAPI.Services_
{
    public class UslugeService : IUslugeService
    {

        private readonly _150023Context context;
        private readonly IMapper _mapper;

        public UslugeService(_150023Context context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public List<Usluga> Get()
        {
            var list = context.Usluge.ToList();
            return _mapper.Map<List<Usluga>>(list);
        }

        public Usluga GetById(int id)
        {
            var entity = context.Usluge.Find(id);
            return _mapper.Map<Usluga>(entity);
        }


        Dictionary<int, List<Ratings>> usluge = new Dictionary<int, List<Ratings>>();


        private double GetSimilarity(List<Ratings> ratings1, List<Ratings> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double numerator = 0, denominator1 = 0, denominator2 = 0;

            for (int i = 0; i < ratings1.Count; i++)
            {
                numerator = ratings1[i].Rating1 * ratings2[i].Rating1;

                denominator1 = ratings1[i].Rating1 * ratings1[i].Rating1 * 1.0;
                denominator2 = ratings2[i].Rating1 * ratings2[i].Rating1 * 1.0;

            }
            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double denominator = denominator1 * denominator2;
            if (denominator == 0)
            {
                return 0;
            }
            else
            {
                return numerator / denominator;
            }

        }



        private void GetProductsData(int uslugaId)
        {
            List<Usluge> aktivneUsluge = context.Usluge.Where(x => x.Id != uslugaId).ToList();
            List<Ratings> ratings;

            foreach (Usluge item in aktivneUsluge)
            {
                ratings = context.Ratings.Where(x => x.UslugeId == item.Id).OrderBy(x => x.KlijentId).ToList();

                if (ratings.Count > 0)
                {
                    usluge.Add(item.Id, ratings);
                }
            }


        }

        public List<Usluga> GetRecommendedUsluge(int uslugaId)
        {
            GetProductsData(uslugaId);

            List<Ratings> ratingsOfThisUsluga = context.Ratings.Where(x => x.UslugeId == uslugaId).OrderBy(x => x.KlijentId).ToList();

            List<Ratings> ratings1 = new List<Ratings>();
            List<Ratings> ratings2 = new List<Ratings>();

            List<Usluge> recommendedUsluge = new List<Usluge>();

            foreach (var item in usluge)
            {
                foreach (Ratings r in ratingsOfThisUsluga)
                {
                    if (item.Value.Where(x => x.KlijentId == r.KlijentId).Count() > 0)
                    {
                        ratings1.Add(r);
                        ratings2.Add(item.Value.Where(x => x.KlijentId == r.KlijentId).First());
                    }
                }

                double similarity = 0;
                similarity = GetSimilarity(ratings1, ratings2);

                if (similarity > 0.6)
                {
                    recommendedUsluge.Add(context.Usluge.Where(p => p.Id == item.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            return _mapper.Map<List<Model.Usluga>>(recommendedUsluge);

        }

        public Usluga Insert(UslugeUpsertRequest request)
        {
            var entity = _mapper.Map<Usluge>(request);

            context.Usluge.Add(entity);
            context.SaveChanges();

            return _mapper.Map<Usluga>(entity);
        }

        public Usluga Update(int id, UslugeUpsertRequest request)
        {
            var entity = context.Usluge.Find(id);
            context.Usluge.Attach(entity);
            context.Usluge.Update(entity);

            _mapper.Map(request, entity);

            context.SaveChanges();

            return _mapper.Map<Usluga>(entity);
        }
    }
}
