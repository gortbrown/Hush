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
using System.IO;

namespace HashTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxExecButton_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void uxCmdInput_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Execute();
            }
        }

        private void Execute()
        {
            ProcessStartInfo command = new ProcessStartInfo() { FileName = "/bin/bash", Arguments = uxCmdInput.Text + " | tee ~/output.txt" };
            Process p = new Process() { StartInfo = command, };
            p.Start();
            string cmdOutput;
            using (StreamReader readIn = new StreamReader("output.txt"))
            {
                cmdOutput = readIn.ReadToEnd();
                readIn.Close();
            }
            uxOutput.Text = cmdOutput;
        }
    }
}
