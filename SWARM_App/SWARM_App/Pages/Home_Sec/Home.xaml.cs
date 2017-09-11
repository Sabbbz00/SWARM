using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWARM_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        string currentTime;
        DateTime now = DateTime.Now.ToLocalTime();
        List<Person> people = new List<Person>();
        public Home()
        {
            InitializeComponent();

			people = new List<Person> {
				new Person ("Steve Employee", "0001", "101 Address street", "416 416 4166"),
				new Person ("Steve", "0001", "101 Address street", "416 416 4166")
			};
			listViewEmployees.ItemsSource = people;

            now = DateTime.Now.ToLocalTime();
            currentTime = now.Date.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
            TimeName.Text = currentTime;
        }
		private async void ListView_OnItemTapped(object o, ItemTappedEventArgs e)
		{
			var dataItem = e.Item as Person;
            var answer = await DisplayAlert("Item Selected: " + dataItem.Name, "What would you like to do", "View", "Edit");
            if (answer == true)
            {
                await DisplayAlert("test","test1","wrfe");//View click
            }else{
                await DisplayAlert("test", "test2", "wrfe");//Edit Click
            }
        }
        private void leftClick(object sender, EventArgs e)
        {
            now = now.AddDays(-1);
			currentTime = now.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
            TimeName.Text = currentTime;
        }
        private void rightClick(object sender, EventArgs e)
        {
            now = now.AddDays(1);
			currentTime = now.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
            TimeName.Text = currentTime;
        }
    }
}