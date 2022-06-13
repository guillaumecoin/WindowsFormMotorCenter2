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
        private GestionVoiture gestionVoiture;
        

        public FormMain()
        {
            InitializeComponent();
            gestionVoiture = new GestionVoiture();
        }

       
        private void FormMain_Load(object sender, EventArgs e)
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
                lvVoitures.AddVoiture(voiture);
            }

            

            string nbVoiture = gestionVoiture.CompterVoiture();
            txtNbVoiture.Text = nbVoiture; 
            
            

        }

        private void lvVoitures_SelectedIndexChanged(object sender, EventArgs e)
        {


           

        }

        private void AddPageBtn_Click(object sender, EventArgs e)
        {
            FormAddVoiture form = new FormAddVoiture(gestionVoiture);

            if (form.ShowDialog() == DialogResult.OK)
            {
                lvVoitures.Items.Clear();

                List<Voiture> liste = gestionVoiture.ChargerVoiture();
                foreach (Voiture voiture in liste)
                {
                    lvVoitures.AddVoiture(voiture);
                }
            }

        }

        private void lvVoitures_DoubleClick(object sender, EventArgs e)
        {

            FormAddVoiture form = new FormAddVoiture(gestionVoiture);


            if (form.ShowDialog() == DialogResult.OK)
            {



            }

            ListView.SelectedListViewItemCollection selected = lvVoitures.SelectedItems;

            if (selected.Count == 1)
            {
                ModifierVoiture(selected[0].Tag as Voiture);
            }

            modifierToolStripMenuItem_Click(sender, e);

            
            

          







        }
        private void ModifierVoiture(Voiture voiture)
        {
            FormAddVoiture form = new FormAddVoiture(voiture, gestionVoiture);

            if (form.ShowDialog() == DialogResult.OK)
            {
                lvVoitures.Items.Clear();
                foreach (var test in gestionVoiture.ChargerVoiture())
                    lvVoitures.AddVoiture(test);
              /*  if (lvVoitures.UpdateVoiture(voiture) != null)
                {
                    lvVoitures.Items.Clear();
                    List<Voiture> liste = gestionVoiture.ChargerVoiture();
                    foreach (Voiture v in liste)
                    {
                        lvVoitures.AddVoiture(v);
                    }

                    return;
                }
                MessageBox.Show("La voiture n'a pas pu être modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection selected = lvVoitures.SelectedItems;

            if (selected.Count == 1)
            {
                ModifierVoiture(selected[0].Tag as Voiture);
            }

        }

        private void lvNbVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutVoiture();
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvVoitures.SelectedItems;
            // verifier qu'un seul élément a été séléctionné
            modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = (selected.Count == 1);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = lvVoitures.SelectedItems;

            if (selected.Count == 1)
            {
                SupprimerVoiture(selected[0].Tag as Voiture);
            }

        }

        private void SupprimerVoiture(Voiture voiture)
        {
            string message = string.Format("Voulez-vous supprimer la voiture {0}--{1} ?", voiture.IdVoiture, voiture.Modele);

            if(MessageBox.Show(message, "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (gestionVoiture.SupprimerVoiture(voiture))
                {
                    lvVoitures.SupprimerVoiture(voiture);
                }
                else
                {
                    MessageBox.Show("La voiture n'a pas pu être supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AjoutVoiture()
        {
            FormAddVoiture form = new FormAddVoiture(null, FormAddVoiture.FormVoitureMode.Ajout, gestionVoiture);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (lvVoitures.AddVoiture(form.VoitureModifie) == null)
                {
                    MessageBox.Show("La voiture n'a pas pu être modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void test_Click(object sender, EventArgs e)
        {
            FormConnexion form = new FormConnexion();




        }
    }
}

