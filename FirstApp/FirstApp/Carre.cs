using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Carre : Forme, ISommets, IComparable<Carre>
    {
        #region VARIABLE
        private int _cote;
        #endregion

        #region PROPRIETE
        public int Cote
        {
            set { _cote = value; }
            get { return _cote; }
        }

        public int Points
        {
            get { return 4; }
        }
        #endregion

        #region CONSTRUCTEUR

        public Carre() : base()
        {
            Cote = 1;
        }

        public Carre(int cote) : base()
        {
            Cote = cote;
        }

        public Carre(Coordonnee c,int cote) : base(c)
        {
            Cote = cote;
        }

        public Carre(int x, int y, int cote) : base(x,y)
        {
            Cote = cote;
        }

        #endregion

        #region METHODE
        public override string ToString()
        {
            return "Carre de cote "+Cote+" et de coord "+Coord.ToString();
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override bool CoordonneeEstDans(Coordonnee c)
        {
            return ((c.X >=Coord.X && c.X <=(Coord.X + Cote)) && (c.Y >= Coord.Y && c.Y <= (Coord.Y + Cote)));
        }

        public int CompareTo(Carre c)
        {
            return Cote.CompareTo(c.Cote);
        }
        #endregion
    }
}
