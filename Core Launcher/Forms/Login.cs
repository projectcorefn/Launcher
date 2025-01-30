using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Net;
using static Core_Launcher.Forms.Login;
using System.Text;
using System.Diagnostics;
using System.Security.Policy;

namespace Core_Launcher.Forms
{
    public partial class Login : Form
    {
        public Login() //set loggedIn to false
        {
            InitializeComponent();
            Properties.Settings.Default.loggedIn = false;
            Properties.Settings.Default.Save();
            
        }

        private void cuiButton1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.email = cuiTextBox1.Content;
            Properties.Settings.Default.password = cuiTextBox2.Content;
            Properties.Settings.Default.Save();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string email = Properties.Settings.Default.email;
                    string password = Properties.Settings.Default.password;

                    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                    {
                        cuiLabel5.Content = "Email or Password cannot be empty.";
                        return;
                    }

                    string url = $"http://vps.corefn.xyz:3551/api/accountcheck?email={Uri.EscapeDataString(email)}&password={Uri.EscapeDataString(password)}";
                    Console.WriteLine($"Attempting to access URL: {url}");

                    HttpResponseMessage response = client.GetAsync(url).Result;

                    Console.WriteLine($"Response Status Code: {response.StatusCode}");
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Response Content: {responseContent}");

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Request successful!");
                        Properties.Settings.Default.loggedIn = true;
                        Properties.Settings.Default.Save();
                        Close();
                    }
                    else
                    {
                        Console.WriteLine("Invalid email or password");
                        cuiLabel5.Content = "Invalid email or password";
                        Properties.Settings.Default.loggedIn = false;
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("HttpRequestException: " + ex.Message);
                    cuiLabel5.Content = "Servers are down right now.";

                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine("WebException: " + ex.Message);
                    cuiLabel5.Content = "Servers are down right now.";

                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General exception: " + ex.Message);
                    cuiLabel5.Content = "Servers are down right now.";

                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                    }
                }
                Properties.Settings.Default.loggedIn = false;
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e) //opens the create acc website
        {
            Process.Start(new ProcessStartInfo("http://vps.corefn.xyz/") { UseShellExecute = true });
        }

        private void cuiLabel4_Click(object sender, EventArgs e) //logges in with saved info
        {
            cuiTextBox1.Content = Properties.Settings.Default.email;
            cuiTextBox2.Content = Properties.Settings.Default.password;
            cuiButton1_Click_1(sender, e);
        }

        private void cuiLabel3_Load(object sender, EventArgs e) //clears saved info
        {
            Properties.Settings.Default.email = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}