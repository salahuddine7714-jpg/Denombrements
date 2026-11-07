using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {

        static void Main(string[] args)
        {

            bool correct; // mémorise si la saisie est un entier
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
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                n = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;                            
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }

                        }
                        long r = 1;
                        for (int k = 1; k <= n; k++)// calcul de r
                            r *= k;
                        Console.WriteLine(n + "! = " + r);
                        break;

                    case '2':
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                t = int.Parse(Console.ReadLine()); // saisir le nombre
                                Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                n = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        
                        // calcul de r
                        r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        break;

                    case '3':
                        correct = false;
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            t = int.Parse(Console.ReadLine()); // saisir le nombre
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            n = int.Parse(Console.ReadLine()); // saisir le nombre
                            correct = true;

                        }
                        catch
                        {
                            Console.WriteLine("Saisissez un entier");
                        }
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
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
