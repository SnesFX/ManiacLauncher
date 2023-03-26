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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();

            // Set the background image of the form
            string assetsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");
            string maniaBgFilePath = Path.Combine(assetsFolderPath, "maniabg.png");
            if (File.Exists(maniaBgFilePath))
            {
                this.BackgroundImage = Image.FromFile(maniaBgFilePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string steamPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null);
            if (!string.IsNullOrEmpty(steamPath))
            {
                string sonicManiaPath = Path.Combine(steamPath, @"steamapps\common\Sonic Mania\sonicmania.exe");
                System.Diagnostics.Process.Start(sonicManiaPath);
            }
            else
            {
                MessageBox.Show("Steam is not installed on this computer.");
            }
        }
    }
}
