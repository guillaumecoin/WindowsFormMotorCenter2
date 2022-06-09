using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormMotorCenter2.Models
{
    static class Extension
    {
        public static ListViewItem UpdateVoiture(this ListView lv, Voiture voiture)
        {
            if (voiture == null)
                return null;

            ListViewItem lvi = lv.FindItemWithText(voiture.IdVoiture.ToString());

            if (lvi != null)
            {
                lvi.SubItems[1].Text = voiture.PuissanceFiscale.ToString();
                lvi.SubItems[2].Text = voiture.CriterePolution.ToString();
                lvi.SubItems[3].Text = voiture.TypeTransmission;
                lvi.SubItems[4].Text = voiture.Finition;
                lvi.SubItems[5].Text = voiture.Carburant;
                lvi.SubItems[6].Text = voiture.Peinture;
                lvi.SubItems[7].Text = voiture.NbPortes.ToString();
                lvi.SubItems[8].Text = voiture.Marque;
                lvi.SubItems[9].Text = voiture.Modele;
                lvi.SubItems[10].Text = voiture.PrixAchat.ToString();
            }
            return lvi;
        }


        public static ListViewItem AddVoiture (this ListView lv, Voiture voiture)
        {
            if (voiture == null)
                return null;

            ListViewItem lvi = new ListViewItem(new string[] { voiture.IdVoiture.ToString(), voiture.PuissanceFiscale.ToString(), voiture.CriterePolution.ToString(),
                voiture.TypeTransmission,  voiture.Finition, voiture.Carburant, voiture.Peinture, voiture.NbPortes.ToString(), voiture.Marque, voiture.Modele, voiture.PrixAchat.ToString()
                });

            lvi.Tag = voiture;
            lv.Items.Add(lvi);
            return lvi;


        }


        public static bool SupprimerVoiture(this ListView lv, Voiture voiture)
        {
            ListViewItem lvi = lv.FindItemWithText(voiture.IdVoiture.ToString());

            if (lvi != null)
            {
                lv.Items.Remove(lvi);
                return true;

            }

            return false;

        }

    }
}
