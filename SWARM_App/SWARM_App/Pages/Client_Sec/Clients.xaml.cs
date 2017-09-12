using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.Client_Sec;

namespace SWARM_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clients : ContentPage
    {
        List<Client> people = new List<Client>();

        public Clients()
        {
            InitializeComponent();
            people = new List<Client> {
                new Client ("Steve Clients", "1 Street Address", "416 416 4141", "steve@client.com", "Residential", "C0001"),
                new Client ("Adam Seed", "2 Street Address", "416 416 4142", "adam@client.com", "Commercial", "C0002"),
            };

            listViewClients.ItemsSource = people;
        }
        private void SearchBar_OnTextChange(object sender, TextChangedEventArgs e)
        {
            listViewClients.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                listViewClients.ItemsSource = people;
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
                listViewClients.ItemsSource = searchResults;
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
            Navigation.PushAsync(new AddClient());
            //var test = new NavigationPage(new AddClient());
            //test.Title = "Add Client";
            //App.Current.MainPage = test;
		}
    }
}