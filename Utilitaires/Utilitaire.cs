using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee13092022.Utilitaires
{
    public  class Utilitaire
    {
        #region Attributs

        public static List<Utilitaire> CollClasse = new List<Utilitaire>();

        #endregion

        #region Constructeurs

        public Utilitaire()
        {
            Utilitaire.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes

        #endregion
    }
}
