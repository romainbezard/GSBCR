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
    public static class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public static VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEURs
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }

        public static string ChargerCodeSecteur(string matricule)
        {
            string codeSecteur = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from v in context.VISITEURs
                          where v.VIS_MATRICULE == matricule
                          select v.SEC_CODE;
                codeSecteur = req.SingleOrDefault();
            }
            return codeSecteur;
        }

        public static List<VISITEUR> FindByCodeRegion(string codeRegion)
        {
            List<VISITEUR> visiteurs = null;
            using (var context = new GSB_VisiteEntities())
            {
                string reqStr = "select * from VAFFECTATION INNER JOIN VISITEUR ON VISITEUR.VIS_MATRICULE = VAFFECTATION.VIS_MATRICULE Where REG_CODE = '" + codeRegion + "'";
                visiteurs = context.VISITEURs.SqlQuery(reqStr).ToList<VISITEUR>();
            }
            return visiteurs;
        }

        public static List<VISITEUR> FindAll()
        {
            List<VISITEUR> lv = new List<VISITEUR>();

            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                string req = "select distinct * from VISITEUR inner join travailler on travailler.VIS_MATRICULE = visiteur.VIS_MATRICULE  where travailler.tra_role = 'Visiteur' ";

                lv = context.VISITEURs.SqlQuery(req).ToList<VISITEUR>();
            }
            return lv;
        }

    }
}
