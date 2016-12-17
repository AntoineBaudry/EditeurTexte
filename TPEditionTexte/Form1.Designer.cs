namespace TPEditionTexte
{
    partial class fm_principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.mn_principal = new System.Windows.Forms.MenuStrip();
            this.m_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.sd_save = new System.Windows.Forms.SaveFileDialog();
            this.mn_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Location = new System.Drawing.Point(12, 27);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(256, 300);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            // 
            // mn_principal
            // 
            this.mn_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fichier});
            this.mn_principal.Location = new System.Drawing.Point(0, 0);
            this.mn_principal.Name = "mn_principal";
            this.mn_principal.Size = new System.Drawing.Size(280, 24);
            this.mn_principal.TabIndex = 1;
            this.mn_principal.Text = "menuStrip1";
            // 
            // m_fichier
            // 
            this.m_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.mi_ouvrir,
            this.mi_enregistrer,
            this.mi_enregistrerSous,
            this.toolStripMenuItem1,
            this.mi_quitter});
            this.m_fichier.Name = "m_fichier";
            this.m_fichier.Size = new System.Drawing.Size(50, 20);
            this.m_fichier.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_ouvrir.Size = new System.Drawing.Size(222, 22);
            this.mi_ouvrir.Text = "Ouvrir";
            this.mi_ouvrir.Click += new System.EventHandler(this.mi_ouvrir_Click);
            // 
            // mi_enregistrer
            // 
            this.mi_enregistrer.Name = "mi_enregistrer";
            this.mi_enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_enregistrer.Size = new System.Drawing.Size(222, 22);
            this.mi_enregistrer.Text = "Enregistrer";
            this.mi_enregistrer.Click += new System.EventHandler(this.mi_enregistrer_Click);
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mi_enregistrerSous.Size = new System.Drawing.Size(222, 22);
            this.mi_enregistrerSous.Text = "Enregistrer sous ..";
            this.mi_enregistrerSous.Click += new System.EventHandler(this.mi_enregistrerSous_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mi_quitter.Size = new System.Drawing.Size(222, 22);
            this.mi_quitter.Text = "Quitter";
            this.mi_quitter.Click += new System.EventHandler(this.mi_quitter_Click);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            // 
            // fm_principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 339);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.mn_principal);
            this.MainMenuStrip = this.mn_principal;
            this.Name = "fm_principale";
            this.Text = "Editeur de texte";
            this.SizeChanged += new System.EventHandler(this.fm_principale_SizeChanged);
            this.mn_principal.ResumeLayout(false);
            this.mn_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip mn_principal;
        private System.Windows.Forms.ToolStripMenuItem m_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.SaveFileDialog sd_save;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    }
}

