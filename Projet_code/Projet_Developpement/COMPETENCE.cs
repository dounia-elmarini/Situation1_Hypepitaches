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
    public partial class COMPETENCE
    {
        //Récupération et placement des compétences dans un tableau
        public string[] recupComp()
        {
            Connect connect = new Connect();

            connect.Initialize();
            connect.ouvrirConnexion();

            SqlCommand command = new SqlCommand("SELECT COMP_NOM FROM COMPETENCE", connect.connexion);

            List<string> resultats = new List<string>();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                    resultats.Add(reader.GetString(0));
            }
            string[] tab1 = resultats.ToArray();
            return tab1;
        }
    }
}
