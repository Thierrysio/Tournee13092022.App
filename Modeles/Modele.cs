using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public  class Modele
    {
        #region Attributs

        public static List<Modele> CollClasse = new List<Modele>();
        private int _id;
        private string _nom;

        #endregion

        #region Constructeurs

        public Modele(int id, string nom)
        {
            Modele.CollClasse.Add(this);
            _id = id;
            _nom = nom;
        }

        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
