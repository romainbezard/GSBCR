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
    public static class MotifVisiteDAO
    {
        public static MOTIF_VISITE FindById(string code)
        {
            //A faire : rechercher un motif visite par son nom
            MOTIF_VISITE mot;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE
                          where m.MOT_CODE == code
                          select m;
                mot = req.SingleOrDefault<MOTIF_VISITE>();
            }
            return mot;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            //A faire : charger tous les motifs visite
            List<MOTIF_VISITE> motifs = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE/*.Include("leMotifVisite")*/
                          select m;
                motifs = req.ToList<MOTIF_VISITE>();

            }
            return motifs;
        }
    }
}
