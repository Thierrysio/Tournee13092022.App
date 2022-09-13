using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Modeles
{
    public class Lampadaire
    {
        #region Attributs

        public static List<Lampadaire> CollClasse = new List<Lampadaire>();
        private int _id;
        private string _referenceInterne;
        private double _latitude;
        private double _longitude;
        private int _numero;
        private string _adresse;
        private Modele _leModele;
        private TypeEmplacement _leTypeEmplacement;
        #endregion

        #region Constructeurs

        public Lampadaire(int id, string referenceInterne, double latitude, double longitude, int numero, string adresse, Modele leModele, TypeEmplacement leTypeEmplacement)
        {
            Lampadaire.CollClasse.Add(this);
            _id = id;
            _referenceInterne = referenceInterne;
            _latitude = latitude;
            _longitude = longitude;
            _numero = numero;
            _adresse = adresse;
            _leModele = leModele;
            _leTypeEmplacement = leTypeEmplacement;
        }


        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string ReferenceInterne { get => _referenceInterne; set => _referenceInterne = value; }
        public double Latitude { get => _latitude; set => _latitude = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Modele LeModele { get => _leModele; set => _leModele = value; }
        public TypeEmplacement LeTypeEmplacement { get => _leTypeEmplacement; set => _leTypeEmplacement = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
