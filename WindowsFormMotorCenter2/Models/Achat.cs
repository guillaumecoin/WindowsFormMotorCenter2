using System;
using System.Collections.Generic;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class Achat
    {
        public int IdAchat { get; set; }
        public DateTime DateAchat { get; set; }
        public int PrixCatalogue { get; set; }
        public int IdClient { get; set; }
        public int IdVoiture { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Voiture IdVoitureNavigation { get; set; }
    }
}
