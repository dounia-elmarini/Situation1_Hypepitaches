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
        Connect seConnecter = new Connect();

        public list_ajoutemp(GRHProjectEntities1 p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            string[] tab1 = listDip.recupDiplomes();
            cb_dip1.Items.AddRange(tab1);
            string[] tab2 = listComp.recupComp();
            cb_comp1.Items.AddRange(tab2);
            bs_service.DataSource = bd.SERVICE;
            bs_metier.DataSource = bd.METIER;
            bs_comp.DataSource = bd.COMPETENCE;
            bs_contrat.DataSource = bd.CONTRAT;
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
        //Sélection des compétences dans les 3 ComboBox
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
            cb_comp3.Items.Clear();

            cb_comp1.Items.AddRange(tab2);
            cb_comp3.Items.AddRange(tab2);

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            string requeteIdServ, requeteIdMetier, requeteIdContrat, requeteIdEmploye;
            string requete_ajoutEmp, requete_ajoutContrat;
            string nom = tb_nom.Text, prenom = tb_prenom.Text, adresse = tb_adresse.Text, cp = tb_cp.Text, ville = tb_ville.Text, tel = tb_tel.Text, mail = tb_mail.Text, sexe = tb_sexe.Text;
            int idServ, idMetier, idContrat, idEmploye;

            Connect seConnecter = new Connect();

            if(nom == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else if(prenom == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else if (adresse == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else if (cp == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else if (ville == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else if (tb_salaire.Text == "")
            {
                MessageBox.Show(" Les champs nom, prénom, adresse, code postal, ville et salaire sont obligatoires !");
            }
            else
            {
                //Recherche l'id du service
                requeteIdServ = "SELECT SERVICE_ID FROM SERVICE WHERE SERVICE_DESIGNATION = '" + cb_service.Text + "';";
                idServ = trouverId(requeteIdServ);

                //Recherche l'id du metier
                requeteIdMetier = "SELECT METIER_ID FROM METIER WHERE METIER_NOM = '" + cb_metier.Text + "';";
                idMetier = trouverId(requeteIdMetier);

                //Recherche l'id du contrat
                requeteIdContrat = "SELECT CONTRAT_NUM FROM CONTRAT WHERE CONTRAT_NOM = '" + cb_contrat.Text + "';";
                idContrat = trouverId(requeteIdContrat);

                //Ajoute l'employé à la table EMPLOYE
                requete_ajoutEmp = "INSERT INTO EMPLOYE(EMP_NOM, EMP_PRENOM, EMP_ADRESSE, EMP_CP, EMP_VILLE, EMP_TEL, EMP_MAIL, EMP_SEXE, SERV_ID, MET_ID) VALUES('" + nom + "','" + prenom + "','" + adresse + "','" + cp + "','" + ville + "','" + tel + "','" + mail + "','" + sexe + "','" + idServ + "','" + idMetier + "');";
                seConnecter.Insert(requete_ajoutEmp);

                //Recherche l'id de l'employé précedemment ajouté
                requeteIdEmploye = "SELECT EMP_ID FROM EMPLOYE WHERE EMP_NOM = '" + tb_nom.Text + "';";
                idEmploye = trouverId(requeteIdEmploye);

                //Ajoute le contrat à la table SIGNE
                requete_ajoutContrat = "INSERT INTO SIGNE(CONTRAT_NUM, EMP_ID, SALAIRE, DATE_DEBUTS) VALUES('" + idContrat + "','" + idEmploye + "','" + tb_salaire.Text + "','" + dtp.Value.ToShortDateString() + "');";
                seConnecter.Insert(requete_ajoutContrat);

                //Ajoute les compétences à la table DISPOSE
                insertCompetences(idEmploye);

                //Ajoute les diplômes à la table POSSEDE
                insertDiplomes(idEmploye);
            }
        }


        private int trouverId(string requete)
        {
            object reader = seConnecter.Select(requete);
            return Convert.ToInt32(reader);
        }


        //Ajouter les compétences et diplômes pour l'employé créé
        private int trouverIdCompetence(string competence)
        {
            string requeteIdCompetence1 = "SELECT COMP_ID FROM COMPETENCE WHERE COMP_NOM = '" + competence + "';";
            int idCompetence1 = trouverId(requeteIdCompetence1);
            return idCompetence1;
        }

        private int trouverIdDiplome(string diplome)
        {
            string requeteIdDiplome = "SELECT DIPLOME_ID FROM DIPLOME WHERE DIPLOME_NOM = '" + diplome + "';";
            int idDiplome = trouverId(requeteIdDiplome);
            return idDiplome;
        }

        private void insertCompetences(int empId)
        {
            string comp1 = cb_comp1.Text;
            string comp2 = cb_comp2.Text;
            string comp3 = cb_comp3.Text;

            if (comp1 != "")
            {
                int idComp1 = trouverIdCompetence(comp1);
                string requete_competence1 = "INSERT INTO DISPOSE(EMP_ID, COMP_ID) VALUES('" + empId + "','" + idComp1 + "');";
                seConnecter.Insert(requete_competence1);
            }
            if (comp2 != "")
            {
                int idComp2 = trouverIdCompetence(comp2);
                string requete_competence2 = "INSERT INTO DISPOSE(EMP_ID, COMP_ID) VALUES('" + empId + "','" + idComp2 + "');";
                seConnecter.Insert(requete_competence2);
            }
            if (comp3 != "")
            {
                int idComp3 = trouverIdCompetence(comp3);
                string requete_competence3 = "INSERT INTO DISPOSE(EMP_ID, COMP_ID) VALUES('" + empId + "','" + idComp3 + "');";
                seConnecter.Insert(requete_competence3);
            }
        }

        private void insertDiplomes(int empId)
        {
            string dip1 = cb_dip1.Text;
            string dip2 = cb_dip2.Text;
            string dip3 = cb_dip3.Text;
            string requete_ajoutDiplome1, requete_ajoutDiplome2, requete_ajoutDiplome3;

            if (dip1 != "")
            {
                int idDip1 = trouverIdDiplome(dip1);
                requete_ajoutDiplome1 = "INSERT INTO POSSEDE(EMP_ID, DIPLOME_ID) VALUES('" + empId + "','" + idDip1 + "');";
                seConnecter.Insert(requete_ajoutDiplome1);
            }
            if (dip2 != "")
            {
                int idDip2 = trouverIdDiplome(dip2);
                requete_ajoutDiplome2 = "INSERT INTO POSSEDE(EMP_ID, DIPLOME_ID) VALUES('" + empId + "','" + idDip2 + "');";
                seConnecter.Insert(requete_ajoutDiplome2);
            }
            if (dip3 != "")
            {
                int idDip3 = trouverIdDiplome(dip3);
                requete_ajoutDiplome3 = "INSERT INTO POSSEDE(EMP_ID, DIPLOME_ID) VALUES('" + empId + "','" + idDip3 + "');";
                seConnecter.Insert(requete_ajoutDiplome3);
            }
        }
    }
}