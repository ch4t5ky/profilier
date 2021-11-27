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

namespace Profiler
{
    public partial class Expire : Form
    {
        public Expire()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var id = "{14EE456C-84C5-4F6C-BC6E-6FB8787EAC52}";
            Process process = new Process();
            process.StartInfo.FileName = "msiexec";
            process.StartInfo.Arguments = " /x " + id;
            process.Start();
            process.WaitForExit(1000);
            
            Application.Exit();

        }
    }
}
