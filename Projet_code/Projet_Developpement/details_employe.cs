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
        Connect seConnecter = new Connect();
        public details_employe(GRHProjectEntities1 p_bd, EMPLOYE employes)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.EMPLOYE;
            bs_metier.DataSource = bd.METIER;
            bs_service.DataSource = bd.SERVICE;
            bs.DataSource = bd.EMPLOYE.Include("LesDiplomes");
            bs_contrat.DataSource = bd.CONTRAT;
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
            if (bs_signe.Current != null)
            {
                bs_signe.EndEdit();
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
                EMPLOYE leEmploye = (EMPLOYE)bs.Current;
                if (leEmploye.LesServices == null)
                {
                    cb_service.SelectedIndex = -1;
                }
                if (leEmploye.EntityState == EntityState.Detached)
                {
                    bs.EndEdit();
                    bs.RaiseListChangedEvents = false;
                    bd.SaveChanges();
                    bs.RaiseListChangedEvents = true;
                    bs.ResetCurrentItem();
                }
                else
                {
                    bd.SaveChanges();
                }
                bs_autresDiplomes.DataSource = bd.DIPLOME.ToList().Except(leEmploye.LesDiplomes).ToList();
                // En l’absence du dernier « ToList() », l’affectation de « DisplayMember » ci-dessous échoue avec une liste vide
                lb_autresDiplomes.DisplayMember = "DIPLOME_NOM";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_versAutresDiplomes.Visible = bt_versDiplomesPossedes.Visible = lb_autresDiplomes.Visible = true;
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
                }
            }
        }
    }
}