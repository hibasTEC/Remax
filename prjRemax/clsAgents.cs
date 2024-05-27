using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace prjRemax
{
    public class clsAgents
    {
        //la liste
        Dictionary<string, clsAgent> lstAgents;
        private string cElements;

        public int Quantite
        {
            get { return lstAgents.Count; }

        }

        public Dictionary<string,clsAgent>.ValueCollection Element
        {
            get { return lstAgents.Values; }
            
        }

      

        public string Afficher()
        {
            string info=" ";
            foreach(clsAgent agent in lstAgents.Values)
            {
                info+= agent.Afficher();
            }
            return info;
        }

        public bool Ajouter(clsAgent unagent)
        {
            if (lstAgents.ContainsKey(unagent.Numero) == false)
            {
                lstAgents.Add(unagent.Numero, unagent);
                return true;
            }
            return false;

        }



        public bool Existe(string Numero)
        {
            return lstAgents.ContainsKey(Numero);
        }

        public bool Supprimer(string Numero)
        {
           return  lstAgents.Remove(Numero);
        }
    }
}