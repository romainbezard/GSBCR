﻿using System;
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
    }
}
