using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLourde
{
    public partial class LogIn : Form
    {
        Methods methods = new Methods();
        HttpClient client = new HttpClient();

        public static string token;
        public static LoggedUser loggedUser = new LoggedUser();

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        public async void loginButton_Click(object sender, EventArgs e)
        {
            UserInfo userinfo = new UserInfo
            {
                username = textBoxUsername.Text,
                password = textBoxPassword.Text
            };
            List<string> authorizedRoles = new List<string>() {"admin","dev","moderator"};
            var res = await methods.LogIn(userinfo);
            var statusCode = (res.StatusCode).ToString();
            if (statusCode == "OK")
            {
                var resJSON = await res.Content.ReadFromJsonAsync<User>();
                var resRole = ((resJSON.roles)[0].name).ToString();
                if (authorizedRoles.Contains(resRole))
                {
                    token = resJSON.token;

                    loggedUser.username = userinfo.username;
                    loggedUser.password = userinfo.password;
                    loggedUser.email = resJSON.email;

                    switch (resRole)
                    {
                        case "admin":
                            ServiceTechnique serviceTech = new ServiceTechnique();
                            serviceTech.Show();
                            break;
                        case "dev":
                            DevTiers devTiers = new DevTiers();
                            devTiers.Show();
                            break;
                        case "moderator":
                            ServiceCommercial serviceCommercial = new ServiceCommercial();
                            serviceCommercial.Show();
                            break;
                    }
                }
                else
                {
                    reqStatus.Text = "Unauthorized";
                    reqStatus.Visible = true;
                }
            }
            else
            {
                reqStatus.Text = statusCode;
                reqStatus.Visible = true;
            }
            
        }
    }
}
