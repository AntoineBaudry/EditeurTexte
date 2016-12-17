using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEditionTexte
{
    public partial class fm_principale : Form
    {
        public fm_principale()
        {
            InitializeComponent();            
        }

        private void fm_principale_SizeChanged(object sender, EventArgs e)
        {
            rt_texte.Width = this.Width - 40;
            rt_texte.Height = this.Height - 75;
        }

        private void mi_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog()==DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void mi_enregistrerSous_Click(object sender, EventArgs e)
        {
            if (sd_save.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(sd_save.FileName, RichTextBoxStreamType.PlainText);
            }      
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Text = "";
        }

        private void mi_enregistrer_Click(object sender, EventArgs e)
        {

        }



    }
}
