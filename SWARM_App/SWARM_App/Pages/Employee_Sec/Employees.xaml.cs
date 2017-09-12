using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.Employee_Sec;
namespace SWARM_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Employees : ContentPage
    {
        List<Employee> people = new List<Employee>();

        public Employees()
        {
            InitializeComponent();
            people = new List<Employee> {
                new Employee("Kim Montes", "18 Eagle Street", "416 416 4166", "kim@PPP.ca", "Manager", "E0001"),
                new Employee("Brian Morris", "19 Eagle Street", "416 416 4167", "brian@PPP.ca", "Employee", "E0002"),
                new Employee("Fahad Akhlaq", "20 Eagle Street", "416 416 4168", "Fahad@PPP.ca", "Manager", "E0003"),
            };
            listViewEmployees.ItemsSource = people;
        }
        private void SearchBar_OnTextChange(object sender, TextChangedEventArgs e)
        {
            listViewEmployees.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                listViewEmployees.ItemsSource = people;
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
                listViewEmployees.ItemsSource = searchResults;
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
            Navigation.PushAsync(new AddEmployee());
			//var test = new NavigationPage(new AddClient());
			//test.Title = "Add Client";
			//App.Current.MainPage = test;
		}
    }
}