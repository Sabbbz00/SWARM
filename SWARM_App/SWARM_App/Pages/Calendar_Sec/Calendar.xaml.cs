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
		string currentTime;
		DateTime now = DateTime.Now.ToLocalTime();
        List<CalendarItem> schedule = new List<CalendarItem>();

		public Calendar()
        {
            InitializeComponent();
			now = DateTime.Now.ToLocalTime();
			currentTime = now.Date.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
			TimeName.Text = currentTime;
            schedule = new List<CalendarItem> {
                new CalendarItem ("9/12/2017", "9:00", "11:00", "Rat Removal1", "pulls from client list via ID", "E0001"),
                new CalendarItem ("9/11/2017", "9:00", "11:00", "Rat Removal2", "pulls from client list via ID", "E0001"),
                new CalendarItem ("9/13/2017", "9:00", "11:00", "Rat Removal3", "pulls from client list via ID", "E0001"),
            };

			//listViewCalendar.ItemsSource = schedule;
			var searchResults = new List<CalendarItem>();
			foreach (var person in schedule)
			{
				DateTime temp = Convert.ToDateTime(person.Date);
				//TimeName.Text = currentTime.ToString();
				if (temp.ToString("MM / dd / yyyy").Equals(currentTime))
				{
					searchResults.Add(person);
				}
			}
			listViewCalendar.ItemsSource = searchResults;
			
        }
		private void SearchBar_OnTextChange(object sender, TextChangedEventArgs e)
		{
			listViewCalendar.BeginRefresh();
            TimeName.IsVisible = false;
            leftBtn.IsVisible = false;
            rightBtn.IsVisible = false;
			if (string.IsNullOrWhiteSpace(e.NewTextValue))
			{
				TimeName.IsVisible = true;
				leftBtn.IsVisible = true;
				rightBtn.IsVisible = true;
				var searchResults = new List<CalendarItem>();
				foreach (var person in schedule)
				{
					DateTime temp = Convert.ToDateTime(person.Date);
					//TimeName.Text = currentTime.ToString();
					if (temp.ToString("MM / dd / yyyy").Equals(currentTime))
					{
						searchResults.Add(person);
					}
				}
				listViewCalendar.ItemsSource = searchResults;
			}
			else
			{
                var searchResults = new List<CalendarItem>();
				foreach (var person in schedule)
				{
                    if (person.Memo.Contains((e.NewTextValue)))
					{
						searchResults.Add((person));
					}
				}
				listViewCalendar.ItemsSource = searchResults;
			}
		}
		private async void ListView_OnItemTapped(object o, ItemTappedEventArgs e)
		{
            var dataItem = e.Item as CalendarItem;
            var answer = await DisplayAlert("Item Selected: " + dataItem.Memo, "What would you like to do", "View", "Edit");
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
		private void leftClick(object sender, EventArgs e)
		{
			now = now.AddDays(-1);
			currentTime = now.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
			TimeName.Text = currentTime;
			var searchResults = new List<CalendarItem>();
			foreach (var person in schedule)
			{
				DateTime temp = Convert.ToDateTime(person.Date);
				//TimeName.Text = currentTime.ToString();
				if (temp.ToString("MM / dd / yyyy").Equals(currentTime))
				{
					searchResults.Add(person);
				}
			}
			listViewCalendar.ItemsSource = searchResults;
		}
		private void rightClick(object sender, EventArgs e)
		{
			now = now.AddDays(1);
			currentTime = now.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
			TimeName.Text = currentTime;
			var searchResults = new List<CalendarItem>();
			foreach (var person in schedule)
			{
				DateTime temp = Convert.ToDateTime(person.Date);
				//TimeName.Text = currentTime.ToString();
				if (temp.ToString("MM / dd / yyyy").Equals(currentTime))
				{
					searchResults.Add(person);
				}
			}
			listViewCalendar.ItemsSource = searchResults;
		}
    }
}