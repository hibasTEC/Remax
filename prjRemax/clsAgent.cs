using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace prjRemax
{
    public class clsAgent
    {
        private string cNumero;
        private string cNom;
        private clsClients cClients;
        private clsMaisons cMaisons;

        public string Numero
        {
            get { return cNumero; }
            set
            {
                cNumero = value;
            }
        }

        public void Engager(string Numero,string Nom,clsClients Clients)
        {
            //Engager  //Ajouter  //inscrire
            cNumero = Numero;
            cNom = Nom;
            cClients = Clients;
           
        }

       public string ToutesLesMaisons()
      {
            // affichertout les Maisons
           string info= cMaisons.Afficher();
            return info;
        }

        public string Afficher()
        {
            //afficher les info de l'agent
            string info = "";
            info += "L'agent :" + cNom;
            info += "Le numero :" + cNumero;
            info += "La liste des client :" + cClients;
            info += "La liste des maisons :" + cMaisons;
            return info;

        }
    }
}