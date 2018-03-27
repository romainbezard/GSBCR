﻿using System;
using System.Collections.Generic;
using System.Linq;
using GSBCR.modele;

namespace GSBCR.DAL
{
    public static class RapportVisiteDAO
    {
        /// <summary>
        /// Permet de retourner un rapport de visite en connaissant son id
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE FindById(string m, int n)
        {
            RAPPORT_VISITE rv =null;
            // écrire et exécuter la requête Linq
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_MATRICULE == m && r.RAP_NUM == n
                          select r;
                rv = req.SingleOrDefault<RAPPORT_VISITE>();
                
            }
            return rv;

        }
        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui ont un certain état
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="lesEtats">Liste d'états (int)</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> FindByEtatEtVisiteur(List<string> lesMatricules, List<int> lesEtats)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and r.RAP_ETAT in(";
                i = 0;
                foreach (int e in lesEtats)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += e ;
                }
                reqStr += ")";
                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();
                
            } 
            return lesRapports;
        }

        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui concerne un médicament
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="unMedicament">dépot légal medicament (string)</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> FindBymedicamentEtVisiteur(List<string> lesMatricules, string unMedicament)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and (r.RAP_MED1 = '" + unMedicament;
                reqStr += "' or r.RAP_MED2 = '" + unMedicament;
                reqStr += "')";
                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();

            }
            return lesRapports;
        }
        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui concerne un praticien
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="unPraticien">numéro praticien</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> FindByPraticienEtVisiteur(List<string> lesMatricules, Int16 unPraticien)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and r.RAP_PRANUM = " + unPraticien;
                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();

            }
            return lesRapports;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static List<RAPPORT_VISITE> FindByRegionAndEtat(string region, List<int> etat)
        {
            List<RAPPORT_VISITE> rapport = null;
            List<VAFFECTATION> liste = null;
            List<string> matricule = null;
            using (var context = new GSB_VisiteEntities())
            {
                liste = VaffectationDAO.FindByRegion(region);
                foreach(VAFFECTATION v in liste)
                {
                    matricule.Add(v.VIS_MATRICULE);
                }
                rapport = FindByEtatEtVisiteur(matricule, etat);
            }

            return rapport;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données par appel de la procédure stockée addRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void insert(RAPPORT_VISITE r)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //ajout du rapport au contexte
                    context.RAPPORT_VISITE.Add(r);
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }

        }

         /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données par appel de la procédure stockée updRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void update(RAPPORT_VISITE r)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry<RAPPORT_VISITE>(r).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }


    }
}
