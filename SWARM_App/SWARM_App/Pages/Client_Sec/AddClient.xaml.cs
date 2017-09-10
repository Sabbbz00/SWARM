using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Client_Sec
{
    public partial class AddClient : ContentPage
    {
        public AddClient()
        {
            InitializeComponent();
        }
		private void NextClicked(object sender, EventArgs e)
		{
            Navigation.PopAsync();
		}
    }
}
