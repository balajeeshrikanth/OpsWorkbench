using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void opsWorkbenchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here we can record the Logout time");
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            this.ControlBox = false;
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here we can record the start time");
            OperationsWorkbench.Form3 mytargetfrm = new OperationsWorkbench.Form3();
            mytargetfrm.WindowState = FormWindowState.Maximized;
            mytargetfrm.OpsBrowser.Url = new Uri("https://www.cimbclicks.com.my/ibk/");
            mytargetfrm.Show();
            mytargetfrm.OpsBrowser.Width = mytargetfrm.Width;
            mytargetfrm.OpsBrowser.Height = mytargetfrm.Height;
            mytargetfrm.OpsBrowser.ObjectForScripting = true;
            mytargetfrm.OpsBrowser.ScriptErrorsSuppressed = true;

            // new OperationsWorkbench.Form3().Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here we can record the start time");
            OperationsWorkbench.Form4 mywindowform = new OperationsWorkbench.Form4();
            mywindowform.WindowState = FormWindowState.Maximized;
            mywindowform.Show();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here we can record the start time");
            Process p = Process.Start("calc.exe");
        }
    }
}
