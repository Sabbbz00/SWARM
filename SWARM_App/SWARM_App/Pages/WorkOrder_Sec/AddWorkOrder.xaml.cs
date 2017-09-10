using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.WorkOrder_Sec
{
    public partial class AddWorkOrder : ContentPage
    {
        public AddWorkOrder()
        {
            InitializeComponent();
        }
		private void NextClicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
    }
}
