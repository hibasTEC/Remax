using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace prjRemax
{
    public class clsMaisons
    {

        private Dictionary<string, clsMaison> lstMaison;
        public string cElements;

        public clsMaisons(){
            lstMaison = new Dictionary<string, clsMaison>();
        }
        public Dictionary<string, clsMaison>.ValueCollection Element
        {
            get { return lstMaison.Values; }
            
        }
        public int quantite
        {
            get { return lstMaison.Count; } 
        }

        public string Afficher()
        {
            string info;
            info = "Liste des maisons";
            foreach(clsMaison maison in lstMaison.Values)
            {
                info += maison.Afficher();
            }
            return info;
        }

        public bool Ajouter(clsMaison unMaison)
        {

            if (lstMaison.ContainsKey(unMaison.Numero) == false)
            {
                lstMaison.Add(unMaison.Numero, unMaison);
                return true;
            }
            return false;

        }

      

        public bool Existe(string  numero)
        {
            return lstMaison.ContainsKey(numero);
        }

        public bool Supprimer(string Numero)
        {
            return lstMaison.Remove(Numero);
        }

        public string Trouver()
        {
            throw new System.NotImplementedException();
        }
    }
}