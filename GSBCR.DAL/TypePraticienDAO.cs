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
    public static class TypePraticienDAO
    {
        public static TYPE_PRATICIEN FindById(string code)
        {
            //A faire : rechercher un type praticien par son code
            TYPE_PRATICIEN type_prat;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from t in context.TYPE_PRATICIEN
                          where t.TYP_CODE == code
                          select t;
                type_prat = req.SingleOrDefault<TYPE_PRATICIEN>();
            }
            return type_prat;
        }

        public static List<TYPE_PRATICIEN> FindAll()
        {
            //A faire : charger tous les types praticiens
            List<TYPE_PRATICIEN> lesTypesPraticien = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from t in context.TYPE_PRATICIEN
                          select t;
                lesTypesPraticien = req.ToList<TYPE_PRATICIEN>();
            }
            return lesTypesPraticien;
        }

    }
}
