using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace prjRemax
{
    public class clsClient
    {
        private string cNumero;
        private string cNom;
        private clsMaisons cMaisons;

        public clsClient(string Numero, string Nom )
        {
            cNumero = Numero;
            cNom = Nom;
            cMaisons = new clsMaisons();

        }
        public string Numero
        {
            get { return cNumero; }
            set
            {
                cNumero = value;
            }
        }
        public clsClient(string Numero, string Nom, clsMaisons Maison)
        {
            cNumero = Numero;
            cNom = Nom;
            cMaisons = Maison;

        }

        public void Inscrire(string Numero,string Nom,clsMaisons Maison)
        {
            cNumero = Numero;
            cNom = Nom;
            cMaisons = Maison;

        }

        public string Afficher()
        {

            string info = "";
            info += "Numero du client :" + cNumero + "\n Nom du client :" + cNom + "\n les maison du client" + cMaisons;
            return info;
        }
    }
}