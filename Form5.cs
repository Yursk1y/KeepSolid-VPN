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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
            Form6 f = new Form6();
            f.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Global.tick = false;
            
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

        private void OutBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            if (Global.tick == true) 
            {
                OutBox.Text = "Destination location: \n\t" + Global.loadpath + "\nStart Menu Folder: \n\t" + Global.shortpath + "\n Additional tasks: \n\t Additional shortcuts: \n\t\t Create a desktop shortcut";
            }
            else 
            {
                OutBox.Text = "Destination location: \n\t" + Global.loadpath + "Start Menu Folder: \n\t" + Global.shortpath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
