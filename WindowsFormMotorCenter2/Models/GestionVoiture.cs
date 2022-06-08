using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormMotorCenter2.Models
{
    public class GestionVoiture
    {

        motorcenterContext model = new motorcenterContext();

        public List<Voiture> ChargerVoiture()
        {
            return model.Voitures.ToList();
        }

        public Voiture AjouterVoiture(Voiture voiture)
        {
            model.Voitures.Add(voiture);

            if (model.SaveChanges() > 0)
                return voiture;

            return null;
        }

        public Voiture RechercherVoiture(int id)
        {
            return model.Voitures.Find(id);
        }


        public List<Voiture> RechercherParMarque(string name)

        {
            var listeP = model.Voitures.AsEnumerable();
            var liste = listeP.Where(p => p.Marque.StartsWith(name, StringComparison.InvariantCultureIgnoreCase));
            return liste.ToList();
        }





        public Voiture ModifierVoiture(Voiture voiture)
        {
            Voiture voitureChanger = RechercherVoiture(voiture.IdVoiture);
            if (voitureChanger == null)
                return null;

            voitureChanger.PuissanceFiscale = voiture.PuissanceFiscale;
            voitureChanger.CriterePolution = voiture.CriterePolution;
            voitureChanger.TypeTransmission = voiture.TypeTransmission;
            voitureChanger.Finition = voiture.Finition;
            voitureChanger.Carburant = voiture.Carburant;
            voitureChanger.Peinture = voiture.Peinture;
            voitureChanger.NbPortes = voiture.NbPortes;
            voitureChanger.Marque = voiture.Marque;
            voitureChanger.Modele = voiture.Modele;
            voitureChanger.PrixAchat = voiture.PrixAchat;

            model.Entry(voitureChanger).State = EntityState.Modified;

            if (model.SaveChanges() > 0)
                return voitureChanger;

            return null;
        }

        public bool SupprimerVoiture(int id)
        {
            Voiture v = RechercherVoiture(id);
            if (v == null)
                return false;

            return SupprimerVoiture(v);
        }

        public bool SupprimerVoiture(Voiture voiture)
        {
            if (voiture != null)
            {
                model.Voitures.Remove(voiture);
                return (model.SaveChanges() > 0);
            }

            return false;
        }

    }
}
