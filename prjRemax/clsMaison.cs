using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace prjRemax
{
    public class clsMaison
    {
        private string cNumero;
        private string cType;
        private string cModele;
        private string cProvince;
        private string cVille;
        private string cAdresse;
        private bool vstatut;

        public clsMaison(string Type,string Modele,string Province,string Ville,string Adresse)
        {
            cNumero = Numero;
            cModele = Modele;
            cType = Type;
            cProvince = Province;
            cVille = Ville;
            cAdresse = Adresse;
        }
        public clsMaison(string Numero,string Type, string Modele, string Province, string Ville, string Adresse)
        {
            cNumero = Numero;
            cModele = Modele;
            cType = Type;
            cProvince = Province;
            cVille = Ville;
            cAdresse = Adresse;
        }
        public string Numero
        {
            get { return cNumero; }
            set
            {
                cNumero = value;
            }
        }
        public bool Statut
        {
            get { return vstatut ; }
            set
            {
                vstatut = value;
            }
        }

        public void Inscrire(string Numero, string Type, string Modele, string Province, string Ville, string Adresse)
        {
            cNumero = Numero;
            cModele = Modele;
            cType = Type;
            cProvince = Province;
            cVille = Ville;
            cAdresse = Adresse;
        }

      
        public string Afficher()
        {
            string info="";
            info = "Numero de maison:" + cNumero + "\n Type de maison:" + cType + "\n Modèle de maison: " + cModele +
                "\n Province :" + cProvince + "\n Ville :" + cVille;
            return info; 
        }
        public bool Occuper()
        {
            return Statut = true;
        }
    }
}