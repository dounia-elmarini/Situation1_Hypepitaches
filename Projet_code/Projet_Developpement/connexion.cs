using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_Developpement
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();

        }

        private void se_connecter_Click(object sender, EventArgs e)
        {
            Connect connec = new Connect();

            tb_id.Text.ToLower();
            string query = "SELECT COUNT(*) FROM ADMINISTRATEUR WHERE ADMIN_LOGIN = '" + tb_id.Text + "' AND ADMIN_MDP = '" + tb_mdp.Text + "'";
            int retour = connec.Count(query);
            
            if (retour > 0)
            {
                this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Vous êtes connecté !");
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect, veuillez effectuer une nouvelle saisie !");
                tb_id.Clear();
                tb_mdp.Clear();
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
