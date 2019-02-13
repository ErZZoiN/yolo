using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Rectangle : Forme, ISommets, IComparable<Rectangle>
    {
        #region VARIABLE
        private int _longueur;
        private int _largeur;
        #endregion

        #region PROPRIETE
        public int Longueur
        {
            set { _longueur = value; }
            get { return _longueur; }
        }
        
        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public int Points
        {
            get { return 4; }
        }

        public override double Aire
        {
            get { return Largeur*Longueur; }
        }

        #endregion

        #region CONSTRUCTEUR

        public Rectangle(int longueur, int largueur) : base()
        {
            Longueur = longueur;
            Largeur = largueur;
        }

        public Rectangle() : base()
        {
            Longueur = 0;
            Largeur = 0;
        }

        public Rectangle(Coordonnee c, int longueur, int largeur) : base(c)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public Rectangle(int x, int y, int longueur, int largeur) : base(x, y)
        {
            Longueur = longueur;
            Largeur = largeur;
        }
        #endregion

        #region METHODE
        public override string ToString()
        {
            return "Rectangle de longueur " + Longueur + ", de largueur " + Largeur + " et d'origine " + Coord.ToString();
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override bool CoordonneeEstDans(Coordonnee c)
        {
            return c.X >= Coord.X && c.X <= (Coord.X + Longueur) && c.Y >= Coord.Y && c.Y <= (Coord.Y + Largeur);
        }

        public int CompareTo(Rectangle r)
        {
            int buf = Largeur * Longueur;
            return buf.CompareTo(r.Largeur * r.Longueur);
        }
        #endregion
    }
}
