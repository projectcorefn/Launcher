using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using WpfApp6.Services;
using WpfApp6.Services.Launch;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;

namespace Core_Launcher.Pages //Should be fixed now shoutout to eon for the injector
{
    public partial class homePage : UserControl
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            try
            {

                string Path69 = Properties.Settings.Default.gamePath;

                if (string.IsNullOrEmpty(Path69) || Path69 == "NONE")
                {
                    MessageBox.Show("Game path not set. Please configure it in settings.");
                    return;
                }

                string gameExePath = System.IO.Path.Combine(Path69, "FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe");
                if (File.Exists(gameExePath))
                {
                    if (UpdateINI.ReadValue("Auth", "Email") == "NONE" || UpdateINI.ReadValue("Auth", "Password") == "NONE")
                    {
                        MessageBox.Show("Please Add Your Backend Login Info In Settings");
                        return;
                    }

                    string dllDownloadUrl = "http://vps.corefn.xyz:7171/download/backend.dll";

                    WebClient OMG = new WebClient();
                    OMG.DownloadFile(dllDownloadUrl, Path.Combine(Path69, "Engine\\Binaries\\ThirdParty\\NVIDIA\\NVaftermath\\Win64", "GFSDK_Aftermath_Lib.x64.dll"));

                    PSBasics.Start(Path69, "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck",
                                   UpdateINI.ReadValue("Auth", "Email"),
                                   UpdateINI.ReadValue("Auth", "Password"));
                    FakeAC.Start(Path69, "FortniteClient-Win64-Shipping_BE.exe",
                                 "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck",
                                 "r");
                    FakeAC.Start(Path69, "FortniteLauncher.exe",
                                 "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck",
                                 "dsf");

                    PSBasics._FortniteProcess.WaitForExit();

                    try
                    {
                        FakeAC._FNLauncherProcess.Close();
                        FakeAC._FNAntiCheatProcess.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There Has Been An Error Closing");
                    }

                    if (this.Parent is Form parentFormAfterExit)
                    {
                        parentFormAfterExit.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Game executable not found. Please verify the game path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public class Config
        {
            public DownloadConfig Download { get; set; }
        }

        public class DownloadConfig
        {
            public string DLLUrl { get; set; }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            settingsPage settingsPage = new settingsPage();

            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(settingsPage);
            }
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {
            cuiLabel2.Content = Properties.Settings.Default.email;
        }
    }
}