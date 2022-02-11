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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Acc_CheckedChanged(object sender, EventArgs e)
        {
            this.Next.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NAcc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete. If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup?";
                
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, "Exit Setup", buttons,MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        this.Close();
                        Application.Exit();
                    }
                
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
