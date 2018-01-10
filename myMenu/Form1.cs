using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur iesiti?", "EXIT", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaieText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void InsereazaText_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void AnuleazaText_Click(object sender, EventArgs e)
        {

        }

        private void CopiazaText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                richTextBox1.Copy();

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void DeschideDialog_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "I have fun with WINDOWS FORMS ";
            openFileDialog1.Filter = "Text|*.txt|All|*.*";


            openFileDialog1.Filter = "JPEG Images|*.jpg|All Files|*.*";
            openFileDialog1.ShowDialog();
            string Fisier_Ales = "";

            openFileDialog1.Title = "Introduceti o imagine";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operatie nereusita");
            }
            else
            {
                Fisier_Ales = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(Fisier_Ales);

            }

            string Fissier_Ales = "";
            openFileDialog1.Title = "Deschideti un fisier text";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Fissier_Ales = openFileDialog1.FileName;
                richTextBox1.LoadFile(Fissier_Ales, RichTextBoxStreamType.PlainText);

            }


        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Saved_File = "";

            salveazaFis.Title = "Salveaza un Text File";
            salveazaFis.FileName = "";

            salveazaFis.Filter = "Text Files|*.txt|All Files|*.*";

            if (salveazaFis.ShowDialog() != DialogResult.Cancel)
            {
                Saved_File = salveazaFis.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
             
                Font font = fontDialog1.Font;
           
                this.richTextBox1.Text = string.Format("Font: {0}", font.Name);
                this.richTextBox1.Font = font;
            }
        }

        private void CautaText_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
               
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
