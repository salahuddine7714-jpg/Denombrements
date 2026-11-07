using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {

        static int Saissie(string message)
        {
            bool correct = false;
            int valeur = 0;
            while (!correct)
            {
                try
                {
                    Console.Write($"{message} = "); // message envoyer a l'utilisateur
                    valeur = int.Parse(Console.ReadLine()); // saisir le nombre
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Saisissez un entier");
                }
            }
            return valeur;
        }

        static long Permutation(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++)// calcul de r
                r *= k;
            return r;
        }

        static long Arrangement(int t, int n)
        {
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            return r;
        }



        static void Main(string[] args)
        {
            char c = '1';
            int n = 0;
            int t = 0;
            while (c != '0')
            {


                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':

                        n = Saissie("nombre total d'éléments à gérer");
                        long r = Permutation(n);
                        Console.WriteLine(n + "! = " + r);
                        break;

                    case '2':

                        t = Saissie("nombre total d'éléments à gérer");
                        n = Saissie("nombre d'éléments dans le sous ensemble");
                        // calcul de r
                        r = Arrangement(t, n);
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        break;

                    case '3':
                        t = Saissie("nombre total d'éléments à gérer");
                        n = Saissie("nombre d'éléments dans le sous ensemble");
                        // calcul de r1
                        long r1 = Arrangement(t, n);
                        // calcul de r2
                        long r2 = Permutation(n);
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Erreur de saissie");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
