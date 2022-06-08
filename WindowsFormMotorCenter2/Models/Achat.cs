using System;
using System.Collections.Generic;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class Achat
    {
        public Achat()
        {
            Employes = new HashSet<Employe>();
        }

        public int IdAchat { get; set; }
        public DateTime DateAchat { get; set; }
        public int PrixCatalogue { get; set; }
        public int IdClient { get; set; }
        public int IdVoiture { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Voiture IdVoitureNavigation { get; set; }
        public virtual ICollection<Employe> Employes { get; set; }
    }
}
