using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Coordonnee : IEquatable<Object>
    {
        #region VARIABLE
        private int _x;
        private int _y;
        #endregion

        #region PROPRIETE
        public int X
        {
            set { _x = value; }
            get { return _x; }
        }

        public int Y
        {   set { _y = value; }
            get { return _y; }
        }
        #endregion

        #region CONSTRUCTEUR

       public Coordonnee()
        {
            _x = 0;
            _y = 0;
        }

        public Coordonnee(int x, int y)
        {
            _x = x;
            _y = y;
        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }


        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            var coordonnee = obj as Coordonnee;
            return coordonnee != null &&
                   X == coordonnee.X &&
                   Y == coordonnee.Y;
        }



        #endregion
    }
}
