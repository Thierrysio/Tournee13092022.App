using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class Tournee
    {
        #region Attributs

        public static List<Tournee> CollClasse = new List<Tournee>();
        private DateTime _dateHeureDebut;
        private double _coordGPS;
        private Technicien _leTechnicien;
        private List<Intervention> _lesInterventions;
        #endregion

        #region Constructeurs

        public Tournee(DateTime dateHeureDebut, double coordGPS, Technicien leTechnicien)
        {
            Tournee.CollClasse.Add(this);
            _dateHeureDebut = dateHeureDebut;
            _coordGPS = coordGPS;
            _leTechnicien = leTechnicien;

            _lesInterventions = new List<Intervention>();
        }


        #endregion

        #region Getters/Setters
        public DateTime DateHeureDebut { get => _dateHeureDebut; set => _dateHeureDebut = value; }
        public double CoordGPS { get => _coordGPS; set => _coordGPS = value; }
        public Technicien LeTechnicien { get => _leTechnicien; set => _leTechnicien = value; }
        public List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        #endregion

        #region Methodes
        public void AjoutIntervention(Intervention param)
        {
            this.LesInterventions.Add(param);
        }
/// <summary>
/// 1- Balayer la collection des interventions de la tournée
/// 
/// </summary>
/// <param name="param"></param>
        public void AffecteInterventionUrgente(Intervention param)
        {
            int x = this.LesInterventions.IndexOf(this.InterventionEnCours());
            this.LesInterventions.Insert(x+1, param);
        }
        public Intervention InterventionEnCours()
        {
            foreach (Intervention uneIntervention in this.LesInterventions)
            {
                if (uneIntervention.Statut.Equals("E"))
                {
                    return uneIntervention;
                }
            }
            return null;

        }
        #endregion
    }
}
