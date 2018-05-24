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
    public static class RegionDAO
    {
        public static REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            REGION reg;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.REGIONs
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();
            }
            return reg;
        }

        public static List<REGION> FindBySecteur(string codeSecteur)
        {
            List<REGION> lesRegions = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.REGIONs
                          where r.SEC_CODE == codeSecteur
                          select r;
                lesRegions = req.ToList<REGION>();
            }
            return lesRegions;
        }

        public static List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            List<REGION> lesRegions = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.REGIONs
                          select r;
                lesRegions = req.ToList<REGION>();
            }
            return lesRegions;
        }

        public static REGION FindByMatricule(string matricule)
        {
            REGION r = new REGION();

            using (var context = new GSB_VisiteEntities())
            {
                var req = from reg in context.REGIONs
                          join t in context.TRAVAILLERs
                          on reg.REG_CODE equals t.REG_CODE
                          where t.VIS_MATRICULE == matricule
                          select reg;
                r = req.SingleOrDefault<REGION>();
            }
            return r;
        }
    }
}
