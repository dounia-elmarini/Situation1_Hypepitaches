using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Projet_Developpement
{
    class Connect
    {
        public SqlConnection connexion;
        private string serveur;
        private string bdd;
        private string id;
        private string mdp;

        public Connect()
        {
            Initialize();
        }

        public void Initialize()
        {
            serveur = "192.168.51.177";
            bdd = "GRHProject";
            id = "sa";
            mdp = "74841929";

            connexion = new SqlConnection("Data Source="+ serveur +"; initial catalog="+ bdd +"; integrated security=false; User Id="+ id +"; Password="+ mdp +"");
        }

        public bool ouvrirConnexion()
        {
            try
            {

                connexion.Open();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Problème de connexion au serveur ...");
                        break;
                    case 1045:
                        MessageBox.Show("Erreur d'identification ...");
                        break;
                    default:
                        MessageBox.Show("Erreur " + ex.Number);
                        break;
                }
                return false;
            }
        }
        
        public bool fermerConnexion()
        {
            try
            {
                connexion.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string query)
        {
            if (this.ouvrirConnexion() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexion);
                cmd.ExecuteNonQuery();
                this.fermerConnexion();
            }
        }

        public void Update(string query)
        {
            if (this.ouvrirConnexion() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexion);
                // cmd.CommandText = query;
                // cmd.Connection = connection;
                // autre methodes que directement dans le MySqlCommand();
                cmd.ExecuteNonQuery();
                this.fermerConnexion();
            }
        }

        public void Delete(string query)
        {
            if (this.ouvrirConnexion() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexion);
                cmd.ExecuteNonQuery();
                this.fermerConnexion();
            }
        }
        
        public SqlDataReader Select(string query)
        {
            SqlDataReader result = null;
            if (this.ouvrirConnexion() == true)
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = connexion;

                result = cmd.ExecuteReader();

                
                return result;
             }
             else
             {
                 return result;
             }
        }

        public int Count(string query)
        {
            int Count = -1;

            if (this.ouvrirConnexion() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexion);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.fermerConnexion();

                return Count;
            }
            else
                return Count;
        }
    }
}
