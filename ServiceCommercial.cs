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
    public partial class ServiceCommercial : Form
    {
        Methods methods = new Methods();
        HttpClient client = new HttpClient();
        public ServiceCommercial()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void saveUsernameButton_Click(object sender, EventArgs e)
        {
            string token = LogIn.token;
            LoggedUser loggedUser = LogIn.loggedUser;
            Debug.WriteLine(loggedUser.username);
            Debug.WriteLine(LogIn.loggedUser.username);
            if (!(string.IsNullOrEmpty(usernameEditBox.Text))) {
                loggedUser.username = usernameEditBox.Text;
            }
            Debug.WriteLine(token);
            Debug.WriteLine(loggedUser.username);
            Debug.WriteLine(LogIn.loggedUser.username);
            var res = await methods.UpdateUsername(token, loggedUser);
            var resStatusCode = (res.StatusCode).ToString();
            Debug.WriteLine(resStatusCode);
            if (resStatusCode == "OK")
            {
                usernameUpdateLabel.Visible = true;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            
        }

        private async void buttonStats_Click(object sender, EventArgs e)
        {
            string token = LogIn.token;
            var res = await methods.GetOrderStats(token);
            Debug.WriteLine(res.ordersCount);
            Debug.WriteLine(res.summOrdersAmount);
            Debug.WriteLine(res.AverageOrderAmount);
            dataGridView1.Rows[0].Cells[0].Value = res.ordersCount;
            dataGridView1.Rows[0].Cells[1].Value = res.summOrdersAmount;
            dataGridView1.Rows[0].Cells[2].Value = res.AverageOrderAmount;
        }
    }
}
