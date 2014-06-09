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
            bs.Position = bs.List.IndexOf(employes);
        }
    }
}
