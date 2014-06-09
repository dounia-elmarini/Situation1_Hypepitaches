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
    public partial class liste_choix : Form
    {
        private GRHProjectEntities1 bd;
        public liste_choix(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void btn_diplome_Click(object sender, EventArgs e)
        {
            liste_dip fenetreDiplomes = new liste_dip(bd);
            fenetreDiplomes.ShowDialog();
        }

        private void btn_metier_Click(object sender, EventArgs e)
        {
            liste_metiers fenetreMetiers = new liste_metiers(bd);
            fenetreMetiers.ShowDialog();
        }

        private void btn_contrat_Click(object sender, EventArgs e)
        {
            liste_contrats fenetreContrats = new liste_contrats(bd);
            fenetreContrats.ShowDialog();
        }
    }
}
