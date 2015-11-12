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
using System.Runtime.InteropServices;
using System.Threading;

namespace OperationsWorkbench
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void Form4_Load(object sender, EventArgs e)
        {
            


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("calc.exe");
            //Thread.Sleep(500); // Allow the process to open it's window
            //p.WaitForInputIdle();
            //SetParent(p.MainWindowHandle, this.Handle);
        }
    }
}
