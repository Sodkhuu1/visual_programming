using System;
using System.IO;
using System.Windows.Forms;
namespace biy_daalt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtMain.Text = File.ReadAllText(ofd.FileName);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtMain.Text);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }
    }
}
