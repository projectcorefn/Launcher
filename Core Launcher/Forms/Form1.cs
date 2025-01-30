using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Core_Launcher.Forms;
using Core_Launcher.Pages;
using Core_Launcher.Properties;
using Login = Core_Launcher.Forms.Login;

namespace Core_Launcher
{
    public partial class Form1 : Form
    {
        public Form1() //show login and home page
        {
            InitializeComponent();
            bool loggedin = Properties.Settings.Default.loggedIn;

            AddPage("homePage");
            Login login = new Login();
            login.ShowDialog();
        }

        private void AddPage(string pageName) //Add page to main panel
        {

            MainPanel.Controls.Clear();


            switch (pageName)
            {
                case "homePage":
                    homePage homePage = new homePage();
                    homePage.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(homePage);
                    break;

                case "aboutPage":
                    aboutPage aboutPage = new aboutPage();
                    aboutPage.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(aboutPage);
                    break;

                default:
                    MessageBox.Show("Page not found.");
                    break;
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e) //close button
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            AddPage("aboutPage");
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            AddPage("newsPage");
        }

        private void cuiPictureBox1_Load(object sender, EventArgs e)
        {

        }
    }
}