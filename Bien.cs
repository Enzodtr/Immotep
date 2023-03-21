using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    internal class Bien
    {
        public string leProprietaire;
        public int leNbPieces;
        public double laSurface;
        public string lEtat;
        public double lePrix;
        public DateTime? laDateDispo;
        public Adresse lAdresse;
        public Personne lelocataire;
        public Bien ()
        {

        }


        public Bien(Adresse uneAdresse, double uneSurface, int unNbPieces)
        {
            this.lAdresse = uneAdresse;
            this.laSurface = uneSurface;
            this.leNbPieces = unNbPieces;
        }
        public double AugmenterLoyer(double unIndice)
        {
            return -1;
        }
        public void DonnerPreavis(DateTime uneDate)
        { 

        }

        public string Afficher()
        {
            return "NbPieces : " + this.leNbPieces + "\n" +
                   "Surface : " + this.laSurface + "\n" +
                   "Adresse : " + this.lAdresse.Afficher();

        }


    }
}
