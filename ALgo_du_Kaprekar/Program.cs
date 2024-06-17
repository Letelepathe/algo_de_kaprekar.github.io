using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALgo_du_Kaprekar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICES 1 RECUEIL CSHARP PAGE 7
            RESOLU PAR HABACUC LETELEPATHE LECRYPTOLOGUE
             * LUNDI,LE 16/12/2019 à 04H48
             * PROBLEME
             * UN PROGRAMME QUI TROUVE LE NOMBRE DE KAPREKAR
             */ 
            //Declaration des variables
            int p, u, v, n, l;
            string nbre;
            //Corps Du Programme
            Console.WriteLine("tapez un nombre");
            n = int.Parse(Console.ReadLine());
            p = (int)Math.Pow(n, 2);
            l = p.ToString().Length;
            nbre = p.ToString();

       //Structure Conditionnelle 
            if (l > 4)
            {
                u = int.Parse(nbre.Substring(0, (int)(l / 2)-1));
                v = int.Parse(nbre.Substring((int)l / 2, l - (int)l / 2));
            }
            else
            {
                u = int.Parse(nbre.Substring(0, (int)l / 2));
                v = int.Parse(nbre.Substring((int)l / 2, l - (int)l / 2));
            }
            if (n==(v+u))
            Console.WriteLine(v+u+" est un nombre de kaprekar");
            else
                Console.WriteLine(v + u + "n' est pas  un nombre de kaprekar");
            Console.ReadKey();
        }
    }
}
