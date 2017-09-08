using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Login_Sec
{
    public partial class Reset_QuestionPage : ContentPage
    {
        public Reset_QuestionPage()
        {
            InitializeComponent();
        }
		private void NextButton_Clicked(object sender, EventArgs e)
		{
            var test = new Reset_NewPassword();
			App.Current.MainPage = test;
		}
		private void BackButton_Clicked(object sender, EventArgs e)
		{
            var test = new Reset_EmailPage();
			App.Current.MainPage = test;
		}
    }
}
