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
    public partial class liste_emp : Form
    {
       private GRHProjectEntities1 bd;
       public liste_emp(GRHProjectEntities1 p_bd)
       {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.EMPLOYE;
       }


       private void eMPLOYEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           if (eMPLOYEDataGridView.Columns[e.ColumnIndex].Name == "Details")
           {
               EMPLOYE lesEmployes = (EMPLOYE)(eMPLOYEDataGridView.CurrentRow.DataBoundItem);

               if (lesEmployes != null)
               {
                   details_employe fcom = new details_employe(bd, lesEmployes);
                   fcom.ShowDialog();
               }

           }
       }

       private void btn_ajoutemp_Click(object sender, EventArgs e)
       {
           list_ajoutemp ajout_emp = new list_ajoutemp(bd);
           ajout_emp.ShowDialog();
       }




    }
}
