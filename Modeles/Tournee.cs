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

        #endregion
    }
}
