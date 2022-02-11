using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepSolid_VPN
{
    
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete. If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, "Exit Setup", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
                Application.Exit();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Global.loadpath = "";
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            

            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                this.textBox1.Text = openFileDlg.SelectedPath;
                Global.shortpath = openFileDlg.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Next.Enabled = true;
        }
    }
    
}
