using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;



namespace prjRemax
{
    public class Compagnie
    {
        private string cNom;
        private string cAdresse;
        private clsAgents cAgents;
        private clsClients cClients;
        private clsMaisons cMaisons;

        public string Nom
        {
            get { return cNom; }
            set { cNom = value; }

        }
        public string Adresse
        {
            get { return cAdresse; }
            set { cAdresse = value; }
        }
        public clsAgents Agents
        {
            get { return cAgents; }
        }
        public string Afficher()
        {
            string info = "";
            info = "le nom :"+cNom+"\n l'adresse :"+cAdresse+"\n liste des agents "+cAgents;
            return info;
        }

        public clsClients ToutsLesClients()
        {
            // variable de type clsClients  qui va regrouper tout les clients
            clsClients ToutClients=new clsClients();
            //ouvrir la connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            //creer la requette;
            string sql = "SELECT Numero, Nom, Maisons FROM Clients";
            SqlCommand mycmd = new SqlCommand(sql, con);
            SqlDataReader myreader = mycmd.ExecuteReader();
            while (myreader.Read())
            {
                clsClient tmp = new clsClient(myreader["Numero"].ToString(), myreader["Nom"].ToString());
                ToutClients.Ajouter(tmp);
            }
            myreader.Close();
            con.Close();
            return ToutClients;
        }

        public clsMaisons ToutsLesMaisons()
        {
            // variable de type clsClients  qui va regrouper tout les clients
            clsMaisons ToutMaisons = new clsMaisons();
            //ouvrir la connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            //creer la requette;
            string sql = "SELECT * FROM Maisons";
            SqlCommand mycmd = new SqlCommand(sql, con);
            SqlDataReader myreader = mycmd.ExecuteReader();
            while (myreader.Read())
            {
                clsMaison tmp = new clsMaison(myreader["Type"].ToString(), myreader["Modele"].ToString(), myreader["Province"].ToString(), myreader["Nom"].ToString(),myreader["Adresse"].ToString());
                ToutMaisons.Ajouter(tmp);
            }
            myreader.Close();
            con.Close();
            return ToutMaisons;
        }
    }
}