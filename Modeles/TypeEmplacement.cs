using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class TypeEmplacement
    {
        #region Attributs

        public static List<TypeEmplacement> CollClasse = new List<TypeEmplacement>();
        private int _id;
        private string _nom;
        #endregion

        #region Constructeurs

        public TypeEmplacement(int id, string nom)
        {
            TypeEmplacement.CollClasse.Add(this);
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
