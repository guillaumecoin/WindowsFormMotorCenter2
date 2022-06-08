using System;
using System.Collections.Generic;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class Client
    {
        public Client()
        {
            Achats = new HashSet<Achat>();
        }

        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Achat> Achats { get; set; }
    }
}
