using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core_Launcher.Pages
{
    public partial class aboutPage : UserControl
    {
        public aboutPage()
        {
            InitializeComponent();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            homePage homePage = new homePage();

            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(homePage);
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://vps.corefn.xyz/") { UseShellExecute = true });
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/WDjUg84jap") { UseShellExecute = true });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.com/users/1189209526403080202") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo("https://discord.com/users/699353540585586759") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo("https://discord.com/users/1163287243805442231") { UseShellExecute = true });
        }
    }
}
