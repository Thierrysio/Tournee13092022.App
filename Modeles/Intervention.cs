using Java.Nio.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class Intervention
    {
        #region Attributs

        public static List<Intervention> CollClasse = new List<Intervention>();
        private double _dureePrevue, _dureeReelle;
        private string _description;
        private string _statut;
        private Panne _laPanne;

        #endregion

        #region Constructeurs

        public Intervention(double dureePrevue, double dureeReelle, string description, string statut, Panne laPanne)
        {
            Intervention.CollClasse.Add(this);
            _dureePrevue = dureePrevue;
            _dureeReelle = dureeReelle;
            _description = description;
            _statut = statut;
            _laPanne = laPanne;
        }

        #endregion

        #region Getters/Setters
        public double DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        public double DureeReelle { get => _dureeReelle; set => _dureeReelle = value; }
        public string Description { get => _description; set => _description = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public Panne LaPanne { get => _laPanne; set => _laPanne = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
