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
    public partial class list_ajoutdip : Form
    {
        private GRHProjectEntities1 bd;
        public int actualiser = 0;

        public list_ajoutdip(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.DIPLOME;
        }

        private void dIPLOMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            bd.SaveChanges();
            actualiser = 1;
        }

        private void list_ajoutdip_FormClosing(object sender, FormClosingEventArgs e)
        {
            bs.EndEdit();
            bd.SaveChanges();
            actualiser = 1;
        }

        private void bs_CurrentChanged_1(object sender, EventArgs e)
        {
            bd.SaveChanges();
            actualiser = 1;
            
        }
    }
}
