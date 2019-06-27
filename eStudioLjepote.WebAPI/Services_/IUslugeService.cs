using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public  interface IUslugeService
    {
         List<Model.Usluga> GetRecommendedUsluge(int uslugaId);
        List<Model.Usluga> Get();
        Model.Usluga GetById(int id);
        Model.Usluga Insert(UslugeUpsertRequest request);
        Model.Usluga Update(int id, UslugeUpsertRequest request);
    }
}
