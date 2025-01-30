using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core_Launcher.Pages
{
    public partial class settingsPage : UserControl
    {
        public settingsPage() //set game path to stored one
        {
            InitializeComponent();
            cuiTextBox2.Content = Properties.Settings.Default.gamePath;
        }

        private void cuiButton2_Click(object sender, EventArgs e) //back button
        {
            homePage homePage = new homePage();

            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(homePage);
            }
        }

        private void cuiButton3_Click(object sender, EventArgs e) //show/hide core login
        {
            if (cuiButton3.Content == "Show")
            {
                cuiTextBox3.Content = Properties.Settings.Default.password;
                cuiTextBox1.Content = Properties.Settings.Default.email;
                cuiButton3.Content = "Hide";
            }
            else
            {
                cuiTextBox3.Content = "";
                cuiTextBox1.Content = "";
                cuiButton3.Content = "Show";
            }
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e) //game path for launcher
        {
            Properties.Settings.Default.gamePath = cuiTextBox2.Content;
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.gamePath);
        }

        private void cuiLabel4_Click(object sender, EventArgs e) //restart (for re logging in)
        {
            try
            {
                string exePath = Application.ExecutablePath;

                System.Diagnostics.Process.Start(exePath);

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while restarting the application: " + ex.Message);
            }
        }

        private void settingsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
