using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Employee_Sec
{
    public partial class AddEmployee : ContentPage
    {
        public AddEmployee()
        {
            InitializeComponent();

        }
		private void NextClicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
    }
}
