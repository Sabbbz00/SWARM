using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.Calendar_Sec;

namespace SWARM_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar : ContentPage
    {
        List<Person> people = new List<Person>();

		public Calendar()
        {
            InitializeComponent();
            //people = new List<Person> {
            //    new Person ("Steve Calendar", "0001", "101 Address street", "416 416 4166"),
            //    new Person ("Steve", "0001", "101 Address street", "416 416 4166")
            //};

            //listViewCalendar.ItemsSource = people;
        }
		private void SearchBar_OnTextChange(object sender, TextChangedEventArgs e)
		{
			listViewCalendar.BeginRefresh();
			if (string.IsNullOrWhiteSpace(e.NewTextValue))
			{
				listViewCalendar.ItemsSource = people;
			}
			else
			{
				var searchResults = new List<Person>();
				foreach (var person in people)
				{
					if (person.ToString().Contains((e.NewTextValue)))
					{
						searchResults.Add((person));
					}
				}
				listViewCalendar.ItemsSource = searchResults;
			}
		}
		private async void ListView_OnItemTapped(object o, ItemTappedEventArgs e)
		{
			var dataItem = e.Item as Person;
			var answer = await DisplayAlert("Item Selected: " + dataItem.Name, "What would you like to do", "View", "Edit");
			if (answer == true)
			{
				await DisplayAlert("View", "Work in progress", "wrfe");//View click
			}
			else
			{
				await DisplayAlert("Edit", "Work in progress", "wrfe");//Edit Click
			}
		}
		private void AddButton_Clicked(object sender, EventArgs e)
		{
            Navigation.PushAsync(new Add_CalendarItem());
		}
    }
}