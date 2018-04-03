using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public static class FamilleDAO
    {
        public static FAMILLE FindById(string code)
        {
            //A faire : rechercher une famille de médicaments par son codes
            FAMILLE fam;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from f in context.FAMILLEs
                          where f.FAM_CODE == code
                          select f;
                fam = req.SingleOrDefault<FAMILLE>();
            }
            return fam;
        }

        public static List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> famille = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from f in context.FAMILLEs
                          select f;
                famille = req.ToList<FAMILLE>();
            }
            return famille;
        }

    }
}
