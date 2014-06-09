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
    public partial class liste_dip : Form
    {
        private GRHProjectEntities1 bd;
        public liste_dip(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.DIPLOME.Include("LesEmployes");
            lb_employes.DisplayMember = "Patronyme";

        }

        private void dIPLOMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                if (((DIPLOME)bs.Current).EntityState == EntityState.Detached) // il s'ajout d'un ajout
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
            }
        }

        private void liste_dip_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

    }
}
