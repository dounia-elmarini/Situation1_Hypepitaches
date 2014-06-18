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
    public partial class list_empCompetences : Form
    {
        private GRHProjectEntities1 bd;
        public list_empCompetences(GRHProjectEntities1 p_bd, COMPETENCE competences)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.COMPETENCE.Include("LesEmployes");
            bs.Position = bs.List.IndexOf(competences);
        }
    }
}
