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
    public partial class FormMain : Form
    {
        private GestionVoiture gestionVoiture = new GestionVoiture();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvVoitures.Columns.Clear();

            lvVoitures.Columns.Add(new ColumnHeader() { Name = "id_Voiture", Text = "Id", Width = 30 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "puissanceFiscale", Text = "Puissane", Width = 60 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "criterePolution", Text = "Critère Pollution", Width = 100 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "typeTransmission", Text = "Transmission", Width = 80 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "finition", Text = "Finition", Width = 60 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "carburant", Text = "Carburant", Width = 70 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "peinture", Text = "Peinture", Width = 60 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "nbPortes", Text = "Nombres de portes", Width = 130 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "marque", Text = "Marque", Width = 60 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "modele", Text = "Modèle", Width = 60 });
            lvVoitures.Columns.Add(new ColumnHeader() { Name = "prixAchat", Text = "Prix", Width = 50 });

            lvVoitures.Items.Clear();

            List<Voiture> liste = gestionVoiture.ChargerVoiture();
            foreach (Voiture voiture in liste)
            {
                ListViewItem lvi = new ListViewItem(new string[] { voiture.IdVoiture.ToString(), voiture.PuissanceFiscale.ToString(), voiture.CriterePolution.ToString(),
                voiture.TypeTransmission,  voiture.Finition, voiture.Carburant, voiture.Peinture, voiture.NbPortes.ToString(), voiture.Marque, voiture.Modele, voiture.PrixAchat.ToString()
                });

                lvi.Tag = voiture;

                lvVoitures.Items.Add(lvi);
            }

        }

        private void lvVoitures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
