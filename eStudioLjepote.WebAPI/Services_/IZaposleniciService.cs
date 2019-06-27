using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
   public interface IZaposleniciService
    {
        List<Model.Zaposlenik> Get(ZaposleniciSearchRequest request);
        Model.Zaposlenik GetById(int id);
        Model.Zaposlenik Insert(ZaposleniciInsertRequest zaposleniciInsertRequest);
        Model.Zaposlenik Update(int id,ZaposleniciInsertRequest zaposleniciInsertRequest);
        Model.Zaposlenik Authenticiraj(string username, string password);
    }
}
