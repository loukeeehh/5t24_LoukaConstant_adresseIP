using System.Numerics;

namespace _5T24_LoukaConstant_adresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau de noms et d'adresses IP");
            int[] adresseIP;
            string[] tableauNoms = new string [20];
            int[,] MatriceAdresses = new int [20, 4]; 
            int addNoms = 0; //compteur pour noms ajoutés
            int places = 0;
            bool fini = false;
            string nUser;
            string message;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {

                if (!morceauxProg.ajouteNom(ref addNoms, ref tableauNoms))
                    {
                    Console.WriteLine("On ne peut plus prendre plus de données !");
                    fini = true;
                }

                else
                {
                    Console.WriteLine("Encodez l'adresseIP :");
                    morceauxProg.LireAdresseIP(out adresseIP);
                    morceauxProg.ajouteAdresseIP(ref MatriceAdresses, ref adresseIP, ref places);
                }
          
                Console.WriteLine("\n Voulez - vous encoder un autre adresse ? 'o' = oui, 'n' = non");
                nUser = Console.ReadLine();
               
               


            } while (!fini && nUser == "o");

         
            
                Console.WriteLine("Voici les adresses encodées :");
                Console.WriteLine(morceauxProg.ConcateneTout(MatriceAdresses, tableauNoms, addNoms));
            
        }
    }
}
