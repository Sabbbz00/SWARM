using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SWARM_App.Pages.Invoice_Sec
{
    public partial class InvoiceAdd : ContentPage
    {
        public InvoiceAdd()
        {
            InitializeComponent();
        }
		private void NextClicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
    }
}
