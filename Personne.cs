using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    internal class Personne
    {
        public string leNom;
        public string lePrenom;
        public string leTelephone;
        public string lIban;

        public Personne()
        {

        }

        public Personne(string unNom, string unPrenom, string unTelephone, string unIban)
        {
            this.leNom = unNom;
            this.lePrenom = unPrenom;
            this.leTelephone = unTelephone;
            this.lIban = unIban;
        }

        public string Afficher()
        {
            return "Nom :" + this.leNom + "\n" +
                  "Prenom :" + this.lePrenom + "\n" +
                  "Telephone :" + this.leTelephone + "\n" +
                  "Iban :" + this.lIban + "\n" ;
        }



    }
    
}
