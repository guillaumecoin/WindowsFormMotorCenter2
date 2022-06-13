using System;
using System.Collections.Generic;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class Voiture
    {
        public Voiture()
        {
            Achats = new HashSet<Achat>();
        }

        public int IdVoiture { get; set; }
        public int PuissanceFiscale { get; set; }
        public int CriterePolution { get; set; }
        public string TypeTransmission { get; set; }
        public string Finition { get; set; }
        public string Carburant { get; set; }
        public string Peinture { get; set; }
        public int NbPortes { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int PrixAchat { get; set; }

        public virtual ICollection<Achat> Achats { get; set; }
    }
}
