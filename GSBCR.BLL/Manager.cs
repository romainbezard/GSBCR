﻿using System;
using System.Collections.Generic;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class Manager
    {
         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passey
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = VisiteurDAO.FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }
        public static List<VISITEUR> ChargerAllVisiteurs()
        {
            return VisiteurDAO.FindAll();
        }


        public static VISITEUR ChargerVisiteurMatricule(string matricule)
        {
            return VisiteurDAO.FindById(matricule);
        }

        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = VaffectationDAO.FindByMatricule(matricule);
            return vaff;
        }
        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(lm, le);
            return lr;
        }
        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = RapportVisiteDAO.FindById(m, n);
            return r;
        }

        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        /// 
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(String m)
        {
            //A faire : charger les rapports terminés (état = 2 ou 3) du visiteur
            List<RAPPORT_VISITE> lrp = new List<RAPPORT_VISITE>();
            List<int> etat = new List<int>();
            etat.Add(2);
            etat.Add(3);
            List<string> matricule = new List<string>();
            matricule.Add(m);
            lrp = RapportVisiteDAO.FindByEtatEtVisiteur(matricule, etat);
            
            return lrp;
        }





        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = VaffectationDAO.FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = VisiteurDAO.FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }
    /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
    /// </summary>
    /// <param name="code">code région</param>
    /// <returns>List<RAPPORT_VISITE>/returns>
    /// 



    public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code)
        {
            //A faire : charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<RAPPORT_VISITE> lrp = new List<RAPPORT_VISITE>();
            List<int> etat = new List<int>();
            string region = null;
            etat.Add(2);
            etat.Add(3);
            region = code;

            lrp = RapportVisiteDAO.FindByRegionAndEtat(region,etat);

            return lrp;
        }

   public static List<RAPPORT_VISITE> ChargerRapportRegionDelegue(String code)
        {
            List<RAPPORT_VISITE> lr = new List<RAPPORT_VISITE>();

            lr = RapportVisiteDAO.FindByRegion(code);
            return lr;
        }



        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        /// 



        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(String r)
        {
            //A faire : charger les rapports terminés (état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lrp = new List<RAPPORT_VISITE>();
            List<int> etat = new List<int>();
            string region = null;
            etat.Add(2);
            region = r;

            lrp = RapportVisiteDAO.FindByRegionAndEtat(region,etat);
            return lrp;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            RapportVisiteDAO.insert(r);
        }

        public static REGION ChargerRegionMatricule(string matricule)
        {
            REGION r = RegionDAO.FindByMatricule(matricule);
            return r;
        }


        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(Int32 r, string matricule)
        {
            // RapportVisiteDAO.update(r);
            RapportVisiteDAO.MAJ(r, matricule);
        }

        public static void MajEtat(string r)
        {
            // RapportVisiteDAO.update(r);
            VaffectationDAO.MAJROLE(r);
        }
        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = MedicamentDAO.FindById(depot);
            return l;
        }
        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = MedicamentDAO.FindAll();
            return lm;
        }
        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> lmv = MotifVisiteDAO.FindAll();
            return lmv;
        }
        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> lp = PratricienDAO.FindAll();
            return lp;
        }

        /// <summary>
        /// Permet de charger toutes les régions de ce secteur
        /// </summary>
        public static List<REGION> ChargerRegionParSecteur(string codeSecteur)
        {
            List<REGION> lesRegions = RegionDAO.FindBySecteur(codeSecteur);
            return lesRegions;
        }

        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int32 pranum)
        {
            PRATICIEN praticien = PratricienDAO.FindById(pranum);
            return praticien;
        }
        
       public static List<RAPPORT_VISITE> ChargerRapportByPatricien(Int32 pranum)
        {
            List<RAPPORT_VISITE> lesRapports = RapportVisiteDAO.FindByPraticien(pranum);
            return lesRapports;
        }

        public static List<RAPPORT_VISITE> ChargerRapportByRegionDuPraticien(string m)
        {
            List<RAPPORT_VISITE> lesRapports = RapportVisiteDAO.FindByRegionPraticien(m);
            return lesRapports;
        }

        public static RAPPORT_VISITE ChargerRapportByPraticienAndNum(Int32 pranum, Int32 rapnum)
        {
            RAPPORT_VISITE rv = RapportVisiteDAO.FindByPraticienAndRapport(pranum, rapnum);
            return rv;
        }

        public static List<RAPPORT_VISITE> ChargerRapprotByNum(Int32 num)
        {
            List<RAPPORT_VISITE> rv = RapportVisiteDAO.FindByNum(num);
            return rv;
        }

        public static TYPE_PRATICIEN ChargerLeTypeDuPraticien(string type)
        {
            TYPE_PRATICIEN tp = TypePraticienDAO.FindById(type);
            return tp;
        }

        public static List<RAPPORT_VISITE> ChargerRapportParVisiteurEtat(string matricule, List<int> etat)
        {
            List<string> Matricule = new List<string>();
            Matricule.Add(matricule);
            List<RAPPORT_VISITE> liste = RapportVisiteDAO.FindByEtatEtVisiteur(Matricule, etat);
            return liste;
        }

        public static string ChargerLeCodeSecteurDuResponsable(string matricule)
        {
            string codeSecteur = VisiteurDAO.ChargerCodeSecteur(matricule);
            return codeSecteur;
        }


        public static void ChangerEtatRapport(Int32 num)
        {

        }
    }
}
