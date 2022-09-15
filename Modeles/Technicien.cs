using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class Technicien
    {
        #region Attributs

        public static List<Technicien> CollClasse = new List<Technicien>();
        private int _id;
        private string _nom;
        private string _prenom;
        private List<Tournee> _lesTournees;
        private Dictionary <Competence,int> _dicoCompetences;
        #endregion

        #region Constructeurs

        public Technicien(int id, string nom, string prenom)
        {
            Technicien.CollClasse.Add(this);
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _lesTournees = new List<Tournee>();
            _dicoCompetences = new Dictionary<Competence,int>();
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Tournee> LesTournees { get => _lesTournees; set => _lesTournees = value; }
        public Dictionary<Competence, int> DicoCompetences { get => _dicoCompetences; set => _dicoCompetences = value; }

        #endregion

        #region Methodes
        /// <summary>
        /// Cette methode doit effectuer le total 
        /// des primes recues par le technicien
        /// 1 - balayer le dictionnaire
        /// 2 - ajouter à l'attribut resultat(Int) la prime obtenue (value)
        /// </summary>
        /// <returns> le montant total des primes</returns>
        public int GetLesPrimes()
        {
            int resultat = 0;
            foreach(var unDico in this.DicoCompetences)
            {
                resultat += unDico.Value;
            }
            //int x = this._dicoCompetences.Sum(x => x.Value);
            return resultat;
        }   
        #endregion
    }
}
