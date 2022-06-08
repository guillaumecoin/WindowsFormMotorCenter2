
namespace WindowsFormMotorCenter2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvVoitures = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvVoitures
            // 
            this.lvVoitures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVoitures.FullRowSelect = true;
            this.lvVoitures.GridLines = true;
            this.lvVoitures.HideSelection = false;
            this.lvVoitures.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.lvVoitures.Location = new System.Drawing.Point(0, 0);
            this.lvVoitures.Name = "lvVoitures";
            this.lvVoitures.Size = new System.Drawing.Size(800, 450);
            this.lvVoitures.TabIndex = 0;
            this.lvVoitures.UseCompatibleStateImageBehavior = false;
            this.lvVoitures.View = System.Windows.Forms.View.Details;
            this.lvVoitures.SelectedIndexChanged += new System.EventHandler(this.lvVoitures_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvVoitures);
            this.Name = "FormMain";
            this.Text = "Gestion des voitures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVoitures;
    }
}

