using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationsWorkbench
{
    public  partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
                    
            DialogResult dlg = MessageBox.Show("We can record Logout time", "Warning", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.No)
                e.Cancel = true;
            else if (dlg == DialogResult.No)
                e.Cancel = false;
            //MessageBox.Show("Here we can record the end time");
        
    }
    }
}
