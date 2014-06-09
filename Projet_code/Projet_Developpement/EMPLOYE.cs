using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_Developpement
{
    public partial class EMPLOYE
    {
        public string Patronyme
        {
            get
            {
                return EMP_NOM + " " + EMP_PRENOM;
            }
        }

        public bool IsFemme
        {
            get
            {
                return EMP_SEXE == "F";
            }
            set
            {
                if (value)
                {
                    EMP_SEXE = "F";
                }
                else
                {
                    EMP_SEXE = "M";
                }
            }
        }

        public bool IsHomme
        {
            get
            {
                return EMP_SEXE == "M";
            }
            set
            {
                if (value)
                {
                    EMP_SEXE = "M";
                }
                else
                {
                    EMP_SEXE = "F";
                }
            }
        }
    }
}
