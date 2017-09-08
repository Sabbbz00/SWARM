using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.Login_Sec;

namespace SWARM_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            //string email = emailText.Text;
            //string password = passwordText.Text;

            //if (email.ToLower().Equals("kim@test.com") && password.Equals("1234"))
            //{
                var test = new MasterDetailPage1();
                App.Current.MainPage = test;
            //}
            //else
            //{
            //    DisplayAlert("Error", "Incorrect Password or Email", "Retry");
            //}
        }
		private void ResetButton_Clicked(object sender, EventArgs e)
		{
			//string email = emailText.Text;
			//string password = passwordText.Text;

			//if (email.ToLower().Equals("kim@test.com") && password.Equals("1234"))
			//{
            var test = new Reset_EmailPage();
			App.Current.MainPage = test;
			//}
			//else
			//{
			//    DisplayAlert("Error", "Incorrect Password or Email", "Retry");
			//}
		}
    }
}
