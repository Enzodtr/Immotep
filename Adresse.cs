using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    internal class Adresse
    {
        public int leNumero;
        public int leCodePostal;
        public string laRue;
        public string laVille;

        public Adresse(int unNumero, int unCodePostal, string uneRue, string uneVille)
        {
            this.leNumero = unNumero;
            this.leCodePostal = unCodePostal;
            this.laVille = uneVille;
            this.laRue = uneRue;
        }
        public string Afficher()
        {
            return "Numero : " + this.leNumero + "\n" +
                   "Code Postal : " + this.leCodePostal + "\n" +
                   "Ville : " + this.laVille + "\n" +
                   "Rue : " + this.laRue;

        }
    }
}
