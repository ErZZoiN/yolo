using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Cercle : Forme, IComparable<Cercle>
    {
        #region VARIABLE
        private int _rayon;
        #endregion

        #region PROPRIETE
        public int Rayon
        {
            set { _rayon = value; }
            get { return _rayon; }
        }

        public override double Aire
        {
            get { return Math.PI * Rayon * Rayon; }
        }
        #endregion

        #region CONSTRUCTEUR
        public Cercle()
        {
            Rayon = 1;
        }

        public Cercle(int rayon) : base()
        {
            Rayon = rayon;
        }

        public Cercle(Coordonnee c, int rayon) : base(c)
        {
            Rayon = rayon;
        }

        public Cercle(int x, int y, int rayon) : base(x, y)
        {
            Rayon = rayon;
        }
        #endregion

        #region METHODE
        public override string ToString()
        {
            return "cercle de rayon "+Rayon+" et de centre "+Coord;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }


        public override bool CoordonneeEstDans(Coordonnee c)
        {
            return Math.Sqrt(((c.X - Coord.X) * (c.X - Coord.X)) + ((c.Y - Coord.Y) * (c.Y - Coord.Y))) <= Rayon;
        }

        public int CompareTo(Cercle c)
        {
            return Rayon.CompareTo(c.Rayon);
        }
        #endregion
    }
}
