using System;
using System.Collections.Generic;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class Employe
    {
        public int IdEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string MotDePasse { get; set; }
        public int IdAchat { get; set; }

        public virtual Achat IdAchatNavigation { get; set; }
    }
}
