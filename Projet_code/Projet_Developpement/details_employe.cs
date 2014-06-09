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
    public partial class details_employe : Form
    {
        private GRHProjectEntities1 bd;
        public details_employe(GRHProjectEntities1 p_bd, EMPLOYE employes)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.EMPLOYE;
            bs_service.DataSource = bd.SERVICE;
            bs_metier.DataSource = bd.METIER;
            bs_contrat.DataSource = bd.CONTRAT;
            bs.DataSource = bd.EMPLOYE.Include("LesDiplomes");
            bs_autresDiplomes.DataSource = bd.DIPLOME;
            bs.Position = bs.List.IndexOf(employes);
        }

        private void eMPLOYEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

        private void details_employe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if (bs.Current != null) 
            {
                bd.SaveChanges(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void bt_versAutresDiplomes_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (lb_diplomesPossedes.SelectedIndex != -1)
                {
                    EMPLOYE leEmploye = (EMPLOYE)bs.Current;
                    DIPLOME leDiplome = (DIPLOME)lb_diplomesPossedes.SelectedItem;
                    leEmploye.LesDiplomes.Remove(leDiplome);
                    bs_autresDiplomes.Add(leDiplome);
                }
            }
        }

        private void bt_versDiplomesPossedes_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (lb_autresDiplomes.SelectedIndex != -1)
                {
                    EMPLOYE leEmploye = (EMPLOYE)bs.Current;
                    DIPLOME leDiplome = (DIPLOME)lb_autresDiplomes.SelectedItem;
                    leEmploye.LesDiplomes.Add(leDiplome);
                    bs_autresDiplomes.Remove(leDiplome);
} }
        }


    }
}
