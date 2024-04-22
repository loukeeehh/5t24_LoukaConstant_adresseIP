using System.Numerics;

namespace _5T24_LoukaConstant_adresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau de noms et d'adresses IP");
            int nUser;
            int[] adresseIP = { };
            string[] tableauNoms = { };
            int[,] MatriceAdresses = { };
            int maxAdresse = 19;
            int addAdresse = 0; //compteur pour adresses ajoutées 
            int addNoms = 0; //compteur pour noms ajoutés
            int places = 19;
            string message = "";
            string keyWord = "stop";
            string repeatProg;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {

                while (message != keyWord && addAdresse < maxAdresse)
                {
                    morceauxProg.LireOctet(out nUser);
                    nUser = int.Parse(Console.ReadLine());

                    morceauxProg.ajouteNom(ref places, tableauNoms);
                    morceauxProg.LireAdresseIP(adresseIP);
                    morceauxProg.ajouteAdresseIP(ref MatriceAdresses, ref adresseIP, ref places);

                    morceauxProg.ConcateneTout(MatriceAdresses, tableauNoms, addNoms);


                }

                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();


            } while (repeatProg == "o");
        }
    }
}
