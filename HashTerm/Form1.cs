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
            ProcessStartInfo command = new ProcessStartInfo() { FileName = "/bin/bash", Arguments = uxCmdInput.Text + " | tee ~/output.txt" };
            Process p = new Process() { StartInfo = command, };
            p.Start();
            string cmdOutput;
            using (StreamReader readIn = new StreamReader("~/output.txt"))
            {
                cmdOutput = readIn.ReadToEnd();
                readIn.Close();
            }
            using (StreamWriter writeOut = File.AppendText("~/output.html"))
            { 
                writeOut.WriteLine("<html>");
                writeOut.WriteLine("<head>");
                writeOut.WriteLine("<title> Editing document.docx </title>");
                writeOut.WriteLine("</head>");
                writeOut.WriteLine("<body>");
                writeOut.WriteLine("<h1> document.docx </h1>");
                writeOut.Write("<input type=text value=");
                writeOut.Write(cmdOutput);
                writeOut.WriteLine(">");
                writeOut.WriteLine("</body>");
                writeOut.WriteLine("</html>");
                writeOut.Close();
            }
            uxWebView.Url = new Uri("~/output.html");
        }
    }
}
