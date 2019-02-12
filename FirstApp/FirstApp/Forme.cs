using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public abstract class Forme : IEstDans
    {
        #region VARIABLE
        protected Coordonnee _coordonnee;
        #endregion

        #region PROPRIETE
        public Coordonnee Coord
        { set { _coordonnee = value; }
          get { return _coordonnee; }
        }
        #endregion

        #region CONSTRUCTEUR
        public Forme()
        {
            Coord = new Coordonnee();
        }

        public Forme(Coordonnee c)
        {
            Coord = c;
        }

        public Forme(int x, int y)
        {
            Coordonnee c = new Coordonnee(x, y);
            Coord = c;
        }
        #endregion

        #region METHODE

        public override bool Equals(object obj)
        {
            var forme = obj as Forme;
            return forme != null &&
                   EqualityComparer<Coordonnee>.Default.Equals(_coordonnee, forme._coordonnee) &&
                   EqualityComparer<Coordonnee>.Default.Equals(Coord, forme.Coord);
        }

        public override int GetHashCode()
        {
            var hashCode = -1728249796;
            hashCode = hashCode * -1521134295 + EqualityComparer<Coordonnee>.Default.GetHashCode(_coordonnee);
            hashCode = hashCode * -1521134295 + EqualityComparer<Coordonnee>.Default.GetHashCode(Coord);
            return hashCode;
        }

        public abstract void Affiche();

        public abstract bool CoordonneeEstDans(Coordonnee c);

        #endregion
    }
}
