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

       


    }
}
