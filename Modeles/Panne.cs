using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class Panne
    {
        #region Attributs

        public static List<Panne> CollClasse = new List<Panne>();
        private int _idPanne;
        private DateTime _dateHeurePanne;
        private char _statut;
        private bool _urgent;
        private Lampadaire _leLampadaire;
        private List<Intervention> _lesInterventions;

        #endregion

        #region Constructeurs

        public Panne(int idPanne, DateTime dateHeurePanne, char statut, bool urgent, Lampadaire leLampadaire)
        {
            Panne.CollClasse.Add(this);
            _idPanne = idPanne;
            _dateHeurePanne = dateHeurePanne;
            _statut = statut;
            _urgent = urgent;
            _leLampadaire = leLampadaire;
            _lesInterventions = new List<Intervention>();
        }

        #endregion

        #region Getters/Setters
        public int IdPanne { get => _idPanne; set => _idPanne = value; }
        public DateTime DateHeurePanne { get => _dateHeurePanne; set => _dateHeurePanne = value; }
        public char Statut { get => _statut; set => _statut = value; }
        public bool Urgent { get => _urgent; set => _urgent = value; }
        public Lampadaire LeLampadaire { get => _leLampadaire; set => _leLampadaire = value; }
        public List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
