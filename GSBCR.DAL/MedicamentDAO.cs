using System.Collections.Generic;
using System.Linq;
using GSBCR.modele;


namespace GSBCR.DAL
{
    public static class MedicamentDAO
    {
        public static MEDICAMENT FindById(string depot)
        {
            //A faire : rechercher un médicament par son nom de dépot
            MEDICAMENT med = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENTs.Include("laFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        public static List<MEDICAMENT> FindAll()
        {
            //A faire : charger tous les médicaments
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENTs.Include("laFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
            
        }

        public static List<MEDICAMENT> FindByFamille(string code)
        {
            //A faire : charger tous les médicaments d'une famille
            List<MEDICAMENT> medicament = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MEDICAMENTs
                          where m.FAM_CODE == code
                          select m;
                medicament = req.ToList<MEDICAMENT>();
            }
            return medicament;
        }
    }
}
