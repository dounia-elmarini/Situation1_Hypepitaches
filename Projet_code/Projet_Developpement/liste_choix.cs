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
            bs_dip.DataSource = bd.DIPLOME;
            bs_serv.DataSource = bd.SERVICE;
            bs_emp.DataSource = bd.EMPLOYE;
            bs_metier.DataSource = bd.METIER;
            bs_comp.DataSource = bd.COMPETENCE;
            bs_absence.DataSource = bd.ABSENCE;
        }

        private void btn_ajoutdip_Click(object sender, EventArgs e)
        {
            bd = new GRHProjectEntities1();
            list_ajoutdip ajoutDiplome = new list_ajoutdip(bd);
            ajoutDiplome.ShowDialog();

            if(ajoutDiplome.actualiser > 0)
            {
                dgv_dip.DataSource = null;
                dgv_dip.DataSource = bd.DIPLOME;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd = new GRHProjectEntities1();
            list_ajoutserv ajoutService = new list_ajoutserv(bd);
            ajoutService.ShowDialog();

            if (ajoutService.actualiser > 0)
            {
                dgv_serv.DataSource = null;
                dgv_serv.DataSource = bd.SERVICE;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bd = new GRHProjectEntities1();
            list_ajoutmetier ajoutMetier = new list_ajoutmetier(bd);
            ajoutMetier.ShowDialog();

            if (ajoutMetier.actualiser > 0)
            {
                dgv_metier.DataSource = null;
                dgv_metier.DataSource = bd.METIER;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bd = new GRHProjectEntities1();
            list_ajoutcomp ajoutCompetence = new list_ajoutcomp(bd);
            ajoutCompetence.ShowDialog();

            if (ajoutCompetence.actualiser > 0)
            {
                dgv_comp.DataSource = null;
                dgv_comp.DataSource = bd.COMPETENCE;
            }
        }

        private void btn_addAbsence_Click(object sender, EventArgs e)
        {
            Connect connexion = new Connect();
            connexion.Insert("INSERT INTO ABSENCE (ABSENCE_DATEDEB, ABSENCE_DATEFIN, ABSENCE_DESCRIPTION) VALUES ('" + dtp_1.Value + "', '" + dtp_2.Value + "', '" + cb_emp.Text + " : " + tb_motif.Text + "')");
        }

        private void dgv_comp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_comp.Columns[e.ColumnIndex].Name == "LesEmployes")
            {
                COMPETENCE lesComp = (COMPETENCE)(dgv_comp.CurrentRow.DataBoundItem);

                if (lesComp != null)
                {
                    list_empCompetences fcom = new list_empCompetences(bd, lesComp);
                    fcom.ShowDialog();
                }
            }
        }

        private void dgv_serv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_serv.Columns[e.ColumnIndex].Name == "Employes")
            {
                SERVICE lesServ = (SERVICE)(dgv_serv.CurrentRow.DataBoundItem);

                if (lesServ != null)
                {
                    list_empService fcom = new list_empService(bd, lesServ);
                    fcom.ShowDialog();
                }
            }
        }
    }
}
