using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.Login_Sec;

namespace SWARM_App.Pages.Login_Sec
{
    public partial class Reset_EmailPage : ContentPage
    {
        public Reset_EmailPage()
        {
            InitializeComponent();
        }
		private void NextButton_Clicked(object sender, EventArgs e)
		{
            var test = new Reset_QuestionPage();
			App.Current.MainPage = test;
		}
		private void BackButton_Clicked(object sender, EventArgs e)
		{
            var test = new MainPage();
			App.Current.MainPage = test;
		}
    }
}
