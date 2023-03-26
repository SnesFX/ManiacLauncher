using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ManiacLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonicManiaPath = @"C:\Program Files (x86)\Steam\steamapps\common\Sonic Mania\SonicMania.exe";
            if (File.Exists(sonicManiaPath))
            {
                System.Diagnostics.Process.Start(sonicManiaPath);
            }
            else
            {
                // This is a certified hood classic!
                MessageBox.Show("Sonic Mania is not installed on this computer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // His ass is not quitting!!
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ManiaModManagerPath = @"C:\Program Files (x86)\Steam\steamapps\common\Sonic Mania\ManiaModManager.exe";
            if (File.Exists(ManiaModManagerPath))
            {
                System.Diagnostics.Process.Start(ManiaModManagerPath);
            }
            else
            {
                // Aw yeah, this isn't happening!
                MessageBox.Show("Mania Mod Manager is not installed");
            }
        }
    }
}
