using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Écrivez une fonction en C# nommée CalculerSomme qui prend un tableau d'entiers en entrée et
renvoie la somme de tous les éléments du tableau. 111 DONE

Écrivez une deuxième fonction en C# nommée SommeElementsInferieurs qui prend un tableau
d'entiers et une valeur seuil en entrée, puis renvoie la somme des éléments du tableau qui sont
strictement inférieurs à la valeur seuil. 111 DONE

Utilisez ces fonctions pour calculer la somme totale des éléments d'un tableau donné, ainsi que la
somme des éléments inférieurs à une valeur seuil.

Affichez le tableau ainsi que les résultats à l'utilisateur.
 */

namespace Prog2
{
    internal class Program
    {
        static int CalculerSomme(int[] tableau)
        {
            int some = 0;
            foreach (int i in tableau)
            {
                some += i;
            }
            return some;
        }

        static int SommeElementsInferieurs(int[] tableau,int seuil)
        {
            int some = 0;
            foreach (int i in tableau)
            {
                if(i<=seuil)
                    some += i;
            }
            return some;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enterer la taile de votre tableau : ");
            int taille = Convert.ToInt32(Console.ReadLine());

            int[] tableau = new int[taille];

            for(int i = 0; i<taille;i++)
            {
                Console.Write("Tab[" + i + "] = ");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Donnez le seuil pour stoper la somme de votre tableau : ");
            int valSeuil = Convert.ToInt32(Console.ReadLine());

            int total = CalculerSomme(tableau);
            int seuilTotal = SommeElementsInferieurs(tableau, valSeuil);

            Console.WriteLine("Somme Normale est : "+total);
            Console.WriteLine("Somme Avec arrêt est : "+seuilTotal);

            Console.WriteLine("PRESS SOMTHING TO EXIT : ");

            Console.ReadLine();
        }
    }
}
