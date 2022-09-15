using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournee13092022.Utilitaires;

namespace Tournee13092022.Modeles
{
    public class Panne
    {
        #region Attributs

        public static List<Panne> CollClasse = new List<Panne>();
        private int _idPanne;
        private DateTime _dateHeurePanne;
        private string _statut;
        private bool _urgent;
        private Lampadaire _leLampadaire;
        private List<Intervention> _lesInterventions;

        #endregion

        #region Constructeurs

        public Panne( bool urgent, Lampadaire leLampadaire)
        {
            Panne.CollClasse.Add(this);
            _idPanne = Utilitaire.NouvelIdPanne();
            _dateHeurePanne = DateTime.Now;
           if (urgent)
            {
                _urgent = true;
                _statut = "C";
                this.AjoutInterventionUrgente(_leLampadaire, _urgent);
            }
            else
            {
                _urgent = false;
                _statut = "E";
            }
            
            _leLampadaire = leLampadaire;
            _lesInterventions = new List<Intervention>();
        }

        #endregion

        #region Getters/Setters
        public int IdPanne { get => _idPanne; set => _idPanne = value; }
        public DateTime DateHeurePanne { get => _dateHeurePanne; set => _dateHeurePanne = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public bool Urgent { get => _urgent; set => _urgent = value; }
        public Lampadaire LeLampadaire { get => _leLampadaire; set => _leLampadaire = value; }
        public List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        #endregion

        #region Methodes
        private void AjoutInterventionUrgente(Lampadaire param1,bool param2)
        {
            // 1 - Trouver la tournée la plus proche du lampadaire
            // 2 - Trouver l'intervention en cours de cette tournée
            // 3 - Créer une nouvelle intervention
            // 4 - Affecter cette panne à cette intervention

          Tournee uneTournee =  Utilitaire.TourneePlusProche(this);
          if(uneTournee != null)
            {
                uneTournee.LesInterventions.Add(new Intervention(0, 0,"", "C", this));
            }
        }
        #endregion
    }
}
