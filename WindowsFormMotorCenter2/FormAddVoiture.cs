using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormMotorCenter2.Models;

namespace WindowsFormMotorCenter2
{
    public partial class FormAddVoiture : Form
    {

        public enum FormVoitureMode { Ajout, Modification };
        FormVoitureMode mode;
        private GestionVoiture gestionVoiture = new GestionVoiture();

        public FormAddVoiture()

        {
            InitializeComponent();
           
        }

        public FormAddVoiture(Voiture voiture, FormVoitureMode mode)

        {
            InitializeComponent();
            UpdateMode(voiture, mode);
        }

        public FormAddVoiture(Voiture voiture)
            : this(voiture, FormVoitureMode.Modification)

        {

        }

        private void UpdateMode(Voiture voiture, FormVoitureMode mode)
        {
            this.mode = mode;

            switch (mode)
            {
                case FormVoitureMode.Ajout:
                    this.Text = "Ajout d'une voiture";

                    txtId.Text = "";
                    txtPuissanceF.Text = "";
                    txtCriterePo.Text = "";
                    txtTransmission.Text = "";
                    txtFinition.Text = "";
                    txtCarburant.Text = "";
                    txtPeinture.Text = "";
                    txtNbPorte.Text = "";
                    txtMarque.Text = "";
                    txtModele.Text = "";
                    txtPrix.Text = "";

                    break;

                case FormVoitureMode.Modification:
                    this.Text = "Modification d'une voiture";

                    txtId.Text = voiture.IdVoiture.ToString();
                    txtPuissanceF.Text = voiture.PuissanceFiscale.ToString();
                    txtCriterePo.Text = voiture.CriterePolution.ToString();
                    txtTransmission.Text = voiture.TypeTransmission;
                    txtFinition.Text = voiture.Finition;
                    txtCarburant.Text = voiture.Carburant;
                    txtPeinture.Text = voiture.Peinture;
                    txtNbPorte.Text = voiture.NbPortes.ToString();
                    txtMarque.Text = voiture.Marque;
                    txtModele.Text = voiture.Modele;
                    txtPrix.Text = voiture.PrixAchat.ToString();
                    break;
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        public Voiture VoitureModifie { get; private set; }

        private void ConfirmeBtm_Click(object sender, EventArgs e)
        {
            

            Voiture voitureAModifier = new Voiture()
            {
                IdVoiture = Convert.ToInt32(txtId.Text),
                PuissanceFiscale = Convert.ToInt32(txtPuissanceF.Text),
                CriterePolution = Convert.ToInt32(txtCriterePo.Text),
                TypeTransmission = txtTransmission.Text,
                Finition = txtFinition.Text,
                Carburant = txtCarburant.Text,
                Peinture = txtPeinture.Text,
                NbPortes = Convert.ToInt32(txtNbPorte.Text),
                Marque = txtMarque.Text,
                Modele = txtModele.Text,
                PrixAchat = Convert.ToInt32(txtPrix.Text)

            };

            switch (mode)
            {
                case FormVoitureMode.Ajout:
                    VoitureModifie = gestionVoiture.AjouterVoiture(voitureAModifier);
                    break;

                case FormVoitureMode.Modification:
                    VoitureModifie = gestionVoiture.ModifierVoiture(voitureAModifier);
                    break;

            }
            this.DialogResult = DialogResult.OK;



        }

        private void FormAddVoiture_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMarque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPuissanceF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
