using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
   public interface IKlijentiService
    {
        List<Model.Klijent> Get(KlijentiSearchRequest request);
        Model.Klijent GetById(int id);
        Model.Klijent Insert(KlijentiUpsertRequest request);
        Model.Klijent Update(int id, KlijentiUpsertRequest Request);
        Model.Klijent Authenticiraj(string username, string password);
    }
}
