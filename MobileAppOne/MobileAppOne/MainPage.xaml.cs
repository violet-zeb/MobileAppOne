using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppOne
{
    public partial class MainPage : ContentPage
    {
        private const string Username = "02hero";
        private const string Password = "predavanje3";

        public MainPage()
        {
            InitializeComponent();
            

        }

        private void InfoLabel_Clicked(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == Username
                && PasswordEntry.Text == Password)
            {
                InfoLabel.Text = "login successful";
                InfoLabel.TextColor = Color.Green;
            }
            else
            {
                InfoLabel.Text = "login unsuccessful";
                InfoLabel.TextColor = Color.Red;
            }
        }
    }
}