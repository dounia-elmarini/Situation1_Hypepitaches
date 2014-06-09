using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace Projet_Developpement

{
    public partial class list_ajoutemp : Form
    {
        int compteur1 = 0;
        int compteur2 = 0;
        private GRHProjectEntities1 bd;
        DIPLOME listDip = new DIPLOME();
        COMPETENCE listComp = new COMPETENCE();
        
        public list_ajoutemp(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            string[] tab1 = listDip.recupDiplomes();
            cb_dip1.Items.AddRange(tab1);
            string[] tab2 = listComp.recupComp();
            cb_comp1.Items.AddRange(tab2);
            bs_serv.DataSource = bd.SERVICE;
            bs_metier.DataSource = bd.METIER;
            bs_comp.DataSource = bd.COMPETENCE;
        }

        //DIPLOMES
        //Sélection des diplômes dans les 3 ComboBox
        private void bt_ajouterDiplome_Click_1(object sender, EventArgs e)
        {
            string[] tab1 = listDip.recupDiplomes();
            tb_compter1.Text = compteur1.ToString();
            compteur1 = Int32.Parse(tb_compter1.Text);
            tb_compter1.Text = compteur1++.ToString();

            if (compteur1 < 3)
            {
                if (cb_dip2.Visible == false)
                {
                    cb_dip1.Text.ToLower();
                    cb_dip2.Visible = true;
                    cb_dip2.Items.Clear();
                    cb_dip2.Items.AddRange(tab1);

                    cb_dip2.Items.Remove(cb_dip1.Text);
                }
                else
                {
                    cb_dip2.Text.ToLower();
                    cb_dip3.Visible = true;
                    cb_dip3.Items.Clear();
                    cb_dip3.Items.AddRange(tab1);

                    cb_dip3.Items.Remove(cb_dip1.Text);
                    cb_dip3.Items.Remove(cb_dip2.Text);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez ajouter que 3 diplômes !");
            }
        }


        //Modification en cascade dans les ComboBox
        private void cb_dip1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab1 = listDip.recupDiplomes();
            cb_dip2.Items.Clear();
            cb_dip3.Items.Clear();

            cb_dip2.Items.AddRange(tab1);
            cb_dip3.Items.AddRange(tab1);

            cb_dip1.Text.ToLower();
            cb_dip2.Text.ToLower();
            cb_dip2.Items.Remove(cb_dip1.Text);
            cb_dip3.Items.Remove(cb_dip1.Text);
            cb_dip3.Items.Remove(cb_dip2.Text);
            cb_dip2.Items.Remove(cb_dip3.Text);
        }

        private void cb_dip2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab1 = listDip.recupDiplomes();
            cb_dip1.Items.Clear();
            cb_dip3.Items.Clear();

            cb_dip1.Items.AddRange(tab1);
            cb_dip3.Items.AddRange(tab1);

            cb_dip2.Text.ToLower();
            cb_dip3.Text.ToLower();
            cb_dip3.Items.Remove(cb_dip1.Text);
            cb_dip1.Items.Remove(cb_dip2.Text);
            cb_dip3.Items.Remove(cb_dip2.Text);
            cb_dip1.Items.Remove(cb_dip3.Text);
        }

        private void cb_dip3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab1 = listDip.recupDiplomes();
            cb_dip1.Items.Clear();
            cb_dip2.Items.Clear();

            cb_dip1.Items.AddRange(tab1);
            cb_dip2.Items.AddRange(tab1);

            cb_dip2.Text.ToLower();
            cb_dip3.Text.ToLower();
            cb_dip2.Items.Remove(cb_dip1.Text);
            cb_dip1.Items.Remove(cb_dip2.Text);
            cb_dip1.Items.Remove(cb_dip3.Text);
            cb_dip2.Items.Remove(cb_dip3.Text);
        }


        //COMPETENCES
        //Sélection des diplômes dans les 3 ComboBox
        private void bt_ajouterComp_Click(object sender, EventArgs e)
        {
            tb_compter2.Text = compteur2.ToString();
            compteur2 = Int32.Parse(tb_compter2.Text);
            tb_compter2.Text = compteur2++.ToString();

            string[] tab2 = listComp.recupComp();

            if (compteur2 < 3)
            {
                if (cb_comp2.Visible == false)
                {
                    cb_comp1.Text.ToLower();
                    cb_comp2.Visible = true;
                    cb_comp2.Items.Clear();
                    cb_comp2.Items.AddRange(tab2);

                    cb_comp2.Items.Remove(cb_comp1.Text);
                }
                else
                {
                    cb_comp2.Text.ToLower();
                    cb_comp3.Visible = true;
                    cb_comp3.Items.Clear();
                    cb_comp3.Items.AddRange(tab2);

                    cb_comp3.Items.Remove(cb_comp1.Text);
                    cb_comp3.Items.Remove(cb_comp2.Text);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez ajouter que 3 compétences au maximum !");
            }
        }


        //Modification en cascade dans les ComboBox
        private void cb_comp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab2 = listComp.recupComp();
            cb_comp2.Items.Clear();
            cb_comp3.Items.Clear();

            cb_comp2.Items.AddRange(tab2);
            cb_comp3.Items.AddRange(tab2);

            cb_comp1.Text.ToLower();
            cb_comp2.Text.ToLower();
            cb_comp2.Items.Remove(cb_comp1.Text);
            cb_comp3.Items.Remove(cb_comp1.Text);
            cb_comp3.Items.Remove(cb_comp2.Text);
            cb_comp2.Items.Remove(cb_comp3.Text);
        }

        private void cb_comp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab2 = listComp.recupComp();
            cb_comp1.Items.Clear();
            cb_dip3.Items.Clear();

            cb_comp1.Items.AddRange(tab2);
            cb_dip3.Items.AddRange(tab2);

            cb_comp2.Text.ToLower();
            cb_comp3.Text.ToLower();
            cb_comp3.Items.Remove(cb_comp1.Text);
            cb_comp1.Items.Remove(cb_comp2.Text);
            cb_comp3.Items.Remove(cb_comp2.Text);
            cb_comp1.Items.Remove(cb_comp3.Text);
        }

        private void cb_comp3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tab2 = listComp.recupComp();
            cb_comp1.Items.Clear();
            cb_comp2.Items.Clear();

            cb_comp1.Items.AddRange(tab2);
            cb_comp2.Items.AddRange(tab2);

            cb_comp2.Text.ToLower();
            cb_comp3.Text.ToLower();
            cb_comp2.Items.Remove(cb_comp1.Text);
            cb_comp1.Items.Remove(cb_comp2.Text);
            cb_comp1.Items.Remove(cb_comp3.Text);
            cb_comp2.Items.Remove(cb_comp3.Text);
        }

        private void bt_reset1_Click(object sender, EventArgs e)
        {
            compteur1 = 0;
            tb_compter1.Text = compteur1.ToString();
            cb_dip2.Visible = false;
            cb_dip3.Visible = false;
        }

        private void bt_reset2_Click(object sender, EventArgs e)
        {
            compteur2 = 0;
            tb_compter2.Text = compteur2.ToString();
            cb_comp2.Visible = false;
            cb_comp3.Visible = false;
        }
    }
}
