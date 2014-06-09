using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Developpement
{
    public partial class Main_menu : Form
    {
        private GRHProjectEntities1 bd;

        public Main_menu()
        {
            InitializeComponent();
            bd = new GRHProjectEntities1();
        }

        private void bt_employes_Click_1(object sender, EventArgs e)
        {
            liste_emp fenetreListeEmployes = new liste_emp(bd);
            fenetreListeEmployes.ShowDialog();
        }

        private void bt_gestion_Click(object sender, EventArgs e)
        {
            liste_choix fenetreChoix = new liste_choix(bd);
            fenetreChoix.ShowDialog();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            /*if (connecterLab.ForeColor == System.Drawing.Color.Red)
            {
                connexion seConnecter = new connexion();
                seConnecter.ShowDialog();

                if (DialogResult.Yes == seConnecter.DialogResult)
                {
                    connecterLab.Text = "Déconnexion";
                    connecterLab.Left = 550;

                    bt_employes.Location = new Point(190, 30);
                    l_employes.Location = new Point(192, 92);

                    bt_gestion.Location = new Point(363, 30);
                    l_gestion.Location = new Point(347, 92);

                    bt_historique.Location = new Point(191, 158);
                    l_historique.Location = new Point(184, 218);

                    bt_quitter.Location = new Point(363, 158);
                    l_quitter.Location = new Point(371, 218);

                    connecterLab.ForeColor = System.Drawing.Color.Green;
                    bt_gestion.Visible = l_gestion.Visible = bt_historique.Visible = l_historique.Visible = true;
                }
            }
            else if (connecterLab.ForeColor == System.Drawing.Color.Green)
            {
                deconnexion seDeconnecter = new deconnexion();
                seDeconnecter.ShowDialog();

                if (DialogResult.Yes == seDeconnecter.DialogResult)
                {
                    connecterLab.Text = "Connexion";
                    connecterLab.Left = 556;
                    connecterLab.ForeColor = System.Drawing.Color.Red;

                    bt_gestion.Visible = l_gestion.Visible = bt_historique.Visible = l_historique.Visible = false;


                    bt_employes.Location = new Point(211, 111);
                    l_employes.Location = new Point(213, 173);

                    bt_quitter.Location = new Point(327, 111);
                    l_quitter.Location = new Point(335, 171);
                }
            }*/
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_historique_Click(object sender, EventArgs e)
        {
            list_historique fenetreHistorique = new list_historique(bd);
            fenetreHistorique.ShowDialog();
        }
    }
}
