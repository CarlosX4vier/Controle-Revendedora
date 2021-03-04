using ControleRevendaWF.DAO;
using ControleRevendaWF.Models;
using System.Collections.Generic;
using System.Linq;

namespace ControleRevendaWF.Controllers
{
    class RevendedorasController
    {

        public static List<Revendedora> revendedoras = new List<Revendedora>();

        public Revendedora Get(long id)
        {
            RevendedorasDAO revendedorasDAO = new RevendedorasDAO();
            Revendedora rev = revendedorasDAO.Get(id);
            rev.Catalogos = new CatalogosDAO().GetCatalogosByRevendedora(rev.Id);

            return rev;
        }

        public bool Insert(Revendedora revendedora)
        {
            try
            {
                RevendedorasDAO revendedorasDAO = new RevendedorasDAO();
                revendedora.Id = revendedorasDAO.Insert(revendedora);

                revendedorasDAO.Insert(revendedora);

                return true;
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        public bool Update(Revendedora revendedora)
        {
            try
            {
                RevendedorasDAO revendedorasDAO = new RevendedorasDAO();
                Revendedora revendedoraOld =Get(revendedora.Id);

                for (int i = 0; i < revendedora.Catalogos.Count; i++)
                {
                    bool exists = revendedoraOld.Catalogos.Any(x => x.Id == revendedora.Catalogos[i].Id);
                    if (exists)
                    {
                        revendedorasDAO.UpdateCatalogos(revendedora, revendedora.Catalogos[i]);
                    }
                    else
                    {
                        revendedorasDAO.InsertCatalogos(revendedora, revendedora.Catalogos[i]);
                    }
                }

                return true;
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }
    }
}
