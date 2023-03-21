using Exo;
using System;

namespace ImmoTEP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisie d'un Logement");
            Console.WriteLine("numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Code postal");
            int CodePostal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ville");
            string ville = Console.ReadLine();
            Console.WriteLine("Rue");
            string rue = Console.ReadLine();
            Console.WriteLine("Nombre de pieces");
            int nbPieces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Surface du logement" + "\n");
            int surface = Convert.ToInt32(Console.ReadLine());
            

            //Informations sur le locataire //
            Console.WriteLine("Information clients");
            Console.WriteLine("Nom");
            string Nom = Console.ReadLine();
            Console.WriteLine("Prénom");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Numéro de téléphone");
            string Telephone =  Console.ReadLine();
            Console.WriteLine("IBAN");
            string Iban = Console.ReadLine();

            Console.Clear();
            Adresse adr1 = new Adresse(numero, CodePostal, rue, ville);
            Bien logement1 = new Bien(adr1, surface, nbPieces);
            Personne locataire1 = new Personne(Nom, Prenom, Telephone, Iban);


            Console.WriteLine(adr1.leNumero + " " + adr1.laRue);
            Console.WriteLine(adr1.leCodePostal + " " + adr1.laVille);

            Console.WriteLine(logement1.Afficher());
        }

    }
}