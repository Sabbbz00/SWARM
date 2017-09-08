using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Login_Sec
{
    public partial class Reset_NewPassword : ContentPage
    {
        public Reset_NewPassword()
        {
            InitializeComponent();
        }
		private void NextButton_Clicked(object sender, EventArgs e)
		{
            var test = new MainPage();
			App.Current.MainPage = test;
		}
		private void BackButton_Clicked(object sender, EventArgs e)
		{
            var test = new Reset_QuestionPage();
			App.Current.MainPage = test;
		}
    }
}
