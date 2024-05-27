using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace prjRemax
{
    public class clsClients
    {
        private Dictionary<string, clsClient> lstClients;
        public string cElements;

        public clsClients()
        {
            lstClients = new Dictionary<string, clsClient>();
        }
        public clsClients(string Numero,string Nom)
        {


            lstClients = new Dictionary<string, clsClient>();

        }
        public Dictionary<string,clsClient>.ValueCollection Element
        {
            get { return lstClients.Values; }

            
        }
        public int Quantité
        {
            get { return lstClients.Count ; }
           
        }


        public string Afficher()
        {
            string info = "";
            foreach(clsClient client in lstClients.Values)
            {
               info+=  client.Afficher();
            }
            return info;
            
        }

        public bool Ajouter(clsClient unCient)
        {
            if (lstClients.ContainsKey(unCient.Numero) == false)
            {
                lstClients.Add(unCient.Numero, unCient);
                return true;
            }
            return false;
        }

        public bool Supprimer(string Numero)
        {
            
            
            return lstClients.Remove(Numero);
             
        }

        public bool Existe(string Numero)
        {
            return lstClients.ContainsKey(Numero);
        }
    }
}