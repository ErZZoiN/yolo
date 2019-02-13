using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region INITIALISATION
            #region INITIALISATION DES CARRES

            Console.WriteLine("Creation de deux carres...");
            Carre carre1 = new Carre();
            Carre carre2 = new Carre(3, 4, 5);
            Console.WriteLine("Carre par defaut : ");
            carre1.Affiche();
            Console.WriteLine("Carre initialise : ");
            carre2.Affiche();
            Console.WriteLine("Modification du carre par defaut grace a la propriete :");
            carre1.Cote = 2;
            carre1.Affiche();
            Console.WriteLine();

            #endregion

            #region INITIALISATION DES RECTANGLES

            Console.WriteLine("Creation de deux rectangles...");
            Rectangle rectangle1 = new Rectangle();
            Coordonnee coord_rectangle2 = new Coordonnee(6, 9);
            Rectangle rectangle2 = new Rectangle(coord_rectangle2, 7, 2);
            Console.WriteLine("Rectangle par defaut : ");
            rectangle1.Affiche();
            Console.WriteLine("Rectangle initialise : ");
            rectangle2.Affiche();
            Console.WriteLine("Modification du rectangle par defaut grace a la propriete :");
            rectangle1.Longueur = rectangle2.Largeur;
            rectangle1.Largeur = rectangle2.Longueur;
            rectangle1.Affiche();
            Console.WriteLine();

            #endregion

            #region INITIALISATION DES CERCLES

            Console.WriteLine("Creation de deux cercles...");
            Cercle cercle1 = new Cercle();
            Cercle cercle2 = new Cercle(2, 2, 2);
            Console.WriteLine("Cercle par defaut : ");
            cercle1.Affiche();
            Console.WriteLine("Cercle initialise : ");
            cercle2.Affiche();
            Console.WriteLine("Modification du cercle par defaut grace a la propriete :");
            cercle1.Rayon = 3;
            cercle1.Affiche();

            Console.WriteLine();

            #endregion
            #endregion

            #region TEST DE BOUCLE

            #region LISTE DE FORME

            Console.WriteLine("Création de la liste de forme...");
            List<Forme> liste_de_forme = new List<Forme>{
                carre1,
                carre2,
                rectangle1,
                rectangle2,
                cercle1,
                cercle2
            };
            Console.WriteLine();

            #endregion

            #region FOREACH
            Console.WriteLine("Affichage de la liste grace au foreach...");
            /*foreach (Forme f in liste_de_forme)
                f.Affiche();*/
            Forme.AfficheListe(liste_de_forme);
            Console.WriteLine();
            #endregion

            #region TEST D'IMPLEMENTATION D'INTERFACE

            Console.WriteLine("Ces objets implementent l'interface ISommets : ");
            foreach(Forme f in liste_de_forme)
            {
                if (f is ISommets)
                    f.Affiche();
            }
            Console.WriteLine();
            Console.WriteLine("Ces objets n'implementent pas l'interface ISommets : ");
            foreach(Forme f in liste_de_forme)
            {
                if (!(f is ISommets))
                    f.Affiche();
            }
            Console.WriteLine();

            #endregion

            #endregion

            #region LISTE DE CARRE
            #region TRI DE LISTE

            Console.WriteLine("Creation d'une liste de carre generique...");
            List<Carre> liste_de_carre = new List<Carre>{
                carre1,
                carre2,
                new Carre(1,3,5),
                new Carre(7,9,3),
                new Carre(2,0,4)
            };

            foreach(Carre c in liste_de_carre)
                c.Affiche();
            Console.WriteLine();
            Console.WriteLine("Tri de la liste par taille...");
            liste_de_carre.Sort();
            foreach(Carre c in liste_de_carre)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Tri par abscisse...");
            FormeAbscisseComparer mon_comparer = new FormeAbscisseComparer();
            liste_de_carre.Sort(mon_comparer);
            foreach (Carre c in liste_de_carre)
                c.Affiche();
            Console.WriteLine();

            #endregion

            #region RECHERCHE DANS UNE LISTE

            Carre carre_ref = new Carre(1, 6, 5);

            Console.WriteLine("Recherche des carres avec la meme aire que le carre de reference suivant : ");
            carre_ref.Affiche();
            Console.WriteLine();

            List<Carre> recherche_carre = liste_de_carre.FindAll(x => x.CompareTo(carre_ref)==0);
            Console.WriteLine("Liste :");
            foreach (Carre c in recherche_carre)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Recherche des carres contenant le point de reference suivant : ");
            Coordonnee coord_ref = new Coordonnee(3, 4);
            Console.WriteLine(coord_ref.ToString());

            recherche_carre = liste_de_carre.FindAll(x => x.CoordonneeEstDans(coord_ref));
            foreach (Carre c in recherche_carre)
                c.Affiche();

            Console.WriteLine();
            #endregion
            #endregion

            #region LISTE DE RECTANGLE
            #region TRI DE LISTE
            Console.WriteLine("Creation d'une liste de rectangle generique...");
            List<Rectangle> liste_de_rectangle = new List<Rectangle>{
                rectangle1,
                rectangle2,
                new Rectangle(1,3,5,4),
                new Rectangle(7,9,3,2),
                new Rectangle(2,0,4,3)
            };

            foreach (Rectangle c in liste_de_rectangle)
                c.Affiche();
            Console.WriteLine();
            Console.WriteLine("Tri de la liste par taille...");
            liste_de_rectangle.Sort();
            foreach (Rectangle c in liste_de_rectangle)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Tri par abscisse...");
            liste_de_carre.Sort(mon_comparer);
            foreach (Rectangle c in liste_de_rectangle)
                c.Affiche();
            Console.WriteLine();
            #endregion
            #region RECHERCHE DANS UNE LISTE

            Rectangle rectangle_ref = new Rectangle(1, 6, 1,14);

            Console.WriteLine("Recherche des rectangles avec la meme aire que le rectangle de reference suivant : ");
            rectangle_ref.Affiche();
            Console.WriteLine();

            List<Rectangle> recherche_rectangle = liste_de_rectangle.FindAll(x => x.CompareTo(rectangle_ref)==0);
            Console.WriteLine("Liste :");
            foreach (Rectangle c in recherche_rectangle)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Recherche des rectangles contenant le point de reference suivant : ");
            Console.WriteLine(coord_ref.ToString());

            recherche_rectangle = liste_de_rectangle.FindAll(x => x.CoordonneeEstDans(coord_ref));
            foreach (Rectangle c in recherche_rectangle)
                c.Affiche();

            Console.WriteLine();
            #endregion
            #endregion

            #region LISTE DE CERCLE
            #region TRI DE LISTE
            Console.WriteLine("Creation d'une liste de cercle generique...");
            List<Cercle> liste_de_cercle = new List<Cercle>{
                cercle1,
                cercle2,
                new Cercle(1,3,5),
                new Cercle(7,9,3),
                new Cercle(2,0,4)
            };

            foreach (Cercle c in liste_de_cercle)
                c.Affiche();
            Console.WriteLine();
            Console.WriteLine("Tri de la liste par taille...");
            liste_de_cercle.Sort();
            foreach (Cercle c in liste_de_cercle)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Tri par abscisse...");
            liste_de_cercle.Sort(mon_comparer);
            foreach (Cercle c in liste_de_cercle)
                c.Affiche();
            Console.WriteLine();
            #endregion
            #region RECHERCHE DANS UNE LISTE

            Cercle cercle_ref = new Cercle(1, 6, 1);

            Console.WriteLine("Recherche des cercles avec la meme aire que le cercle de reference suivant : ");
            cercle_ref.Affiche();
            Console.WriteLine();

            List<Cercle> recherche_cercle = liste_de_cercle.FindAll(x => x.CompareTo(cercle_ref)==0);
            Console.WriteLine("Liste :");
            foreach (Cercle c in recherche_cercle)
                c.Affiche();

            Console.WriteLine();
            Console.WriteLine("Recherche des cercles contenant le point de reference suivant : ");
            Console.WriteLine(coord_ref.ToString());

            recherche_cercle = liste_de_cercle.FindAll(x => x.CoordonneeEstDans(coord_ref));
            foreach (Cercle c in recherche_cercle)
                c.Affiche();

            Console.WriteLine();
            #endregion
            #endregion

            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour quitter l'application.");
            Console.ReadKey();
        }
    }
}
