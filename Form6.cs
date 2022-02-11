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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        void Fullfil_ProgressBar()
        {
            double counter = 0;
            progressBar1.Maximum = 10000;
            while (progressBar1.Value < 10000)
            {
                counter += 0.0003;
                if (Math.Floor(counter) % 5 == 0)
                {
                    progressBar1.Value += 1;
                }

            }
            label3.Text = "Succsessfully installed!";
            Next.Enabled = true;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            
                double counter = 0;
                progressBar1.Maximum = 10000;
                while (progressBar1.Value < 10000)
                {
                    counter += 0.0003;
                    if (Math.Floor(counter) % 5 == 0)
                    {
                        progressBar1.Value += 1;
                    }
                }
                label3.Text = "Succsessfully installed!";
                Next.Enabled = true;
            
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
            Form7 f = new Form7();
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
    }
}
