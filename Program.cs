using System.Numerics;

namespace _5T24_LoukaConstant_adresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau de noms et d'adresses IP");
            int[] adresseIP;
            Adresse[] totalAdressesIP = new Adresse[20]; 

            for (int i = 0; i < 20; i++)
            {
                totalAdressesIP[i] = new Adresse();
            }

            int places = 0; //compteur pour adresse ajoutées
            string nom = "";
            bool fini = false;
            string nUser;
            string message;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {
                Console.WriteLine("Entrez un nom :");
                nom = Console.ReadLine();

                Console.WriteLine("Encodez l'adresseIP :");
                morceauxProg.LireAdresseIP(out adresseIP);
                morceauxProg.ajouteAdresseIP(ref totalAdressesIP, ref adresseIP, ref places, nom);
                
          
                Console.WriteLine("\n Voulez - vous encoder un autre adresse ? 'o' = oui, 'n' = non");
                nUser = Console.ReadLine();
               
               


            } while (!fini && nUser == "o");

         
            
                Console.WriteLine("Voici les adresses encodées :");
                Console.WriteLine(morceauxProg.ConcateneTout(totalAdressesIP,places));
            
        }
    }
}
