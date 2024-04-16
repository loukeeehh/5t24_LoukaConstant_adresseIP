namespace _5T24_LoukaConstant_adresseIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau de noms et d'adresses IP");
            int nUser;
            int[] adresseIP;
            string[] tableauNoms;
            int[,] MatriceAdresses;
            int maxAdresse = 20; 
            int addAdresse = 0; //compteur pour adresses ajoutées 
            int addNoms = 0; //compteur pour noms ajoutés
            string message = "";
            string keyWord = "stop";
            string repeatProg;
            fctProcedure morceauxProg = new fctProcedure();

            do
            {

                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();


            } while (repeatProg == "o");
        }
    }
}
