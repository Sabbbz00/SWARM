using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Calendar_Sec
{
    public partial class Add_CalendarItem : ContentPage
    {
        public Add_CalendarItem()
        {
            InitializeComponent();
        }
		private void NextClicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
    }
}
