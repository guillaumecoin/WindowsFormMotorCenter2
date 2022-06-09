
namespace WindowsFormMotorCenter2
{
    partial class FormAddVoiture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPol = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuissanceF = new System.Windows.Forms.TextBox();
            this.txtCriterePo = new System.Windows.Forms.TextBox();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.txtFinition = new System.Windows.Forms.TextBox();
            this.txtCarburant = new System.Windows.Forms.TextBox();
            this.txtPeinture = new System.Windows.Forms.TextBox();
            this.txtNbPorte = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ConfirmeBtm = new System.Windows.Forms.Button();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(129, 74);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(61, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Identifiant";
            this.labelId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(243, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modèle";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peinture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carburant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Finition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type Transmission";
            // 
            // labPol
            // 
            this.labPol.AutoSize = true;
            this.labPol.Location = new System.Drawing.Point(129, 152);
            this.labPol.Name = "labPol";
            this.labPol.Size = new System.Drawing.Size(93, 15);
            this.labPol.TabIndex = 8;
            this.labPol.Text = "Critère Pollution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Puissance Fiscale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Prix Achat";
            // 
            // txtPuissanceF
            // 
            this.txtPuissanceF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuissanceF.Location = new System.Drawing.Point(243, 111);
            this.txtPuissanceF.Name = "txtPuissanceF";
            this.txtPuissanceF.Size = new System.Drawing.Size(100, 23);
            this.txtPuissanceF.TabIndex = 2;
            this.txtPuissanceF.TextChanged += new System.EventHandler(this.txtPuissanceF_TextChanged);
            // 
            // txtCriterePo
            // 
            this.txtCriterePo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCriterePo.Location = new System.Drawing.Point(243, 149);
            this.txtCriterePo.Name = "txtCriterePo";
            this.txtCriterePo.Size = new System.Drawing.Size(100, 23);
            this.txtCriterePo.TabIndex = 3;
            // 
            // txtTransmission
            // 
            this.txtTransmission.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransmission.Location = new System.Drawing.Point(243, 193);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(100, 23);
            this.txtTransmission.TabIndex = 4;
            // 
            // txtFinition
            // 
            this.txtFinition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFinition.Location = new System.Drawing.Point(243, 237);
            this.txtFinition.Name = "txtFinition";
            this.txtFinition.Size = new System.Drawing.Size(100, 23);
            this.txtFinition.TabIndex = 5;
            // 
            // txtCarburant
            // 
            this.txtCarburant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarburant.Location = new System.Drawing.Point(243, 282);
            this.txtCarburant.Name = "txtCarburant";
            this.txtCarburant.Size = new System.Drawing.Size(100, 23);
            this.txtCarburant.TabIndex = 6;
            // 
            // txtPeinture
            // 
            this.txtPeinture.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeinture.Location = new System.Drawing.Point(504, 71);
            this.txtPeinture.Name = "txtPeinture";
            this.txtPeinture.Size = new System.Drawing.Size(100, 23);
            this.txtPeinture.TabIndex = 7;
            // 
            // txtNbPorte
            // 
            this.txtNbPorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNbPorte.Location = new System.Drawing.Point(504, 106);
            this.txtNbPorte.Name = "txtNbPorte";
            this.txtNbPorte.Size = new System.Drawing.Size(100, 23);
            this.txtNbPorte.TabIndex = 8;
            this.txtNbPorte.TextChanged += new System.EventHandler(this.txtMarque_TextChanged);
            // 
            // txtModele
            // 
            this.txtModele.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModele.Location = new System.Drawing.Point(504, 198);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(100, 23);
            this.txtModele.TabIndex = 10;
            // 
            // txtPrix
            // 
            this.txtPrix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrix.Location = new System.Drawing.Point(504, 242);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 23);
            this.txtPrix.TabIndex = 11;
            this.txtPrix.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtMarque
            // 
            this.txtMarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarque.Location = new System.Drawing.Point(504, 144);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(100, 23);
            this.txtMarque.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nombres de portes";
            // 
            // ConfirmeBtm
            // 
            this.ConfirmeBtm.Location = new System.Drawing.Point(475, 371);
            this.ConfirmeBtm.Name = "ConfirmeBtm";
            this.ConfirmeBtm.Size = new System.Drawing.Size(75, 23);
            this.ConfirmeBtm.TabIndex = 22;
            this.ConfirmeBtm.Text = "Confirmer";
            this.ConfirmeBtm.UseVisualStyleBackColor = true;
            this.ConfirmeBtm.Click += new System.EventHandler(this.ConfirmeBtm_Click);
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerBtn.Location = new System.Drawing.Point(298, 371);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnnulerBtn.TabIndex = 23;
            this.AnnulerBtn.Text = "Annuler";
            this.AnnulerBtn.UseVisualStyleBackColor = true;
            // 
            // FormAddVoiture
            // 
            this.AcceptButton = this.ConfirmeBtm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AnnulerBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.AnnulerBtn);
            this.Controls.Add(this.ConfirmeBtm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtNbPorte);
            this.Controls.Add(this.txtPeinture);
            this.Controls.Add(this.txtCarburant);
            this.Controls.Add(this.txtFinition);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.txtCriterePo);
            this.Controls.Add(this.txtPuissanceF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labPol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddVoiture";
            this.Text = "FormAddVoiture";
            this.Load += new System.EventHandler(this.FormAddVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuissanceF;
        private System.Windows.Forms.TextBox txtCriterePo;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.TextBox txtFinition;
        private System.Windows.Forms.TextBox txtCarburant;
        private System.Windows.Forms.TextBox txtPeinture;
        private System.Windows.Forms.TextBox txtNbPorte;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ConfirmeBtm;
        private System.Windows.Forms.Button AnnulerBtn;
    }
}