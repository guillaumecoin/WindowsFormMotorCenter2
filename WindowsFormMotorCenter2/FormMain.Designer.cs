
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
            this.components = new System.ComponentModel.Container();
            this.lvVoitures = new System.Windows.Forms.ListView();
            this.lvNbVoiture = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVoitures
            // 
            this.lvVoitures.FullRowSelect = true;
            this.lvVoitures.GridLines = true;
            this.lvVoitures.HideSelection = false;
            this.lvVoitures.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.lvVoitures.Location = new System.Drawing.Point(158, 34);
            this.lvVoitures.Name = "lvVoitures";
            this.lvVoitures.Size = new System.Drawing.Size(573, 361);
            this.lvVoitures.TabIndex = 0;
            this.lvVoitures.UseCompatibleStateImageBehavior = false;
            this.lvVoitures.View = System.Windows.Forms.View.Details;
            this.lvVoitures.SelectedIndexChanged += new System.EventHandler(this.lvVoitures_SelectedIndexChanged);
            // 
            // lvNbVoiture
            // 
            this.lvNbVoiture.HideSelection = false;
            this.lvNbVoiture.Location = new System.Drawing.Point(12, 43);
            this.lvNbVoiture.Name = "lvNbVoiture";
            this.lvNbVoiture.Size = new System.Drawing.Size(140, 76);
            this.lvNbVoiture.TabIndex = 2;
            this.lvNbVoiture.UseCompatibleStateImageBehavior = false;
            this.lvNbVoiture.View = System.Windows.Forms.View.Details;
            this.lvNbVoiture.SelectedIndexChanged += new System.EventHandler(this.lvNbVoiture_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lvNbVoiture);
            this.Controls.Add(this.lvVoitures);
            this.Name = "FormMain";
            this.Text = "Gestion des voitures";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVoitures;
        private System.Windows.Forms.ListView lvNbVoiture;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

