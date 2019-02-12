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
            foreach (Forme f in liste_de_forme)
                f.Affiche();
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





            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour quitter l'application.");
            Console.ReadKey();
        }
    }
}
