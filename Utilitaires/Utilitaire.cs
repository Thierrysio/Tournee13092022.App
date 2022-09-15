using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tournee13092022.Modeles;

namespace Tournee13092022.Utilitaires
{
    public static class Utilitaire
    {
        #region Attributs


        #endregion

        #region Constructeurs



        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes
        public static double DistanceDeuxLampadaires(Lampadaire a, Lampadaire b)
        {
            Location la = new Location(a.Latitude, a.Longitude);
            Location lb = new Location(b.Latitude, b.Longitude);
            //double resultat = Location.CalculateDistance(la, lb, DistanceUnits.Kilometers);
            //return resultat;
            return Location.CalculateDistance(la, lb, DistanceUnits.Kilometers);

        }

        public static List<Tournee> TourneeEnCours()
        {

            List<Tournee> resultat = new List<Tournee>();
            foreach (Tournee uneTournee in Tournee.CollClasse)
            {
                // je considere que les tournées sont implementées le jour meme
                if (uneTournee.DateHeureDebut >= DateTime.Now)
                {
                    foreach (Intervention uneIntervention in uneTournee.LesInterventions)
                    {
                        if (!uneIntervention.Statut.Equals("T"))
                        {
                            resultat.Add(uneTournee);
                            break;
                        }
                    }

                }
            }

            return resultat;
        }
        public static Tournee TourneePlusProche(Panne param)
        {
            Tournee resultat = null;
            double distanceMini = double.MaxValue;
            foreach (Tournee uneTournee in Utilitaire.TourneeEnCours())
                foreach (Intervention uneIntervention in uneTournee.LesInterventions)
                {
                    double kms = Utilitaire.DistanceDeuxLampadaires(param.LeLampadaire, uneIntervention.LaPanne.LeLampadaire);
                    if (kms < distanceMini)
                    {
                        distanceMini = kms;
                        resultat = uneTournee;
                    }

                }
            return resultat;

        }
        public static int NouvelIdPanne()
        {
            int resultat = 0;

            return resultat;
        }
        #endregion
    }
}
