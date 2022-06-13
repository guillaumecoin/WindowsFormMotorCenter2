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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            Authentification authentification = new Authentification();

            if (authentification.AuthentifierUtilisateur(textId.Text, textMdp.Text))
            {
                

                FormMain formMain = new FormMain();

                formMain.ShowDialog();


                }
            else
            {
                MessageBox.Show("Accès réfusé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
