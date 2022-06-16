using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBS_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("VBScript.vbs", fastColoredTextBox1.Text);
            await Task.Delay(355);
            System.Diagnostics.Process.Start("VBScript.vbs");
            await Task.Delay(1000);
            File.Delete("VBScript.vbs");
        }
    }
}
