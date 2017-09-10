using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SWARM_App;
using SWARM_App.Pages;
using SWARM_App.Pages.WorkOrder_Sec;
namespace SWARM_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkOrders : ContentPage
    {
        List<Person> people = new List<Person>();
        public WorkOrders()
        {
            InitializeComponent();
            people = new List<Person> {
                new Person ("Steve Work Order", "0001", "101 Address street", "416 416 4166"),
                new Person ("Steve", "0001", "101 Address street", "416 416 4166")
            };

            listViewWorkOrders.ItemsSource = people;
        }
		private void SearchBar_OnTextChange(object sender, TextChangedEventArgs e)
		{
			listViewWorkOrders.BeginRefresh();
			if (string.IsNullOrWhiteSpace(e.NewTextValue))
			{
				listViewWorkOrders.ItemsSource = people;
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
				listViewWorkOrders.ItemsSource = searchResults;
			}
		}
		private void ListView_OnItemTapped(object o, ItemTappedEventArgs e)
		{
			var dataItem = e.Item as Person;
			DisplayAlert("Error", dataItem.Name, "Retry");
		}
		private void AddButton_Clicked(object sender, EventArgs e)
		{
            Navigation.PushAsync(new AddWorkOrder());
			//var test = new NavigationPage(new AddClient());
			//test.Title = "Add Client";
			//App.Current.MainPage = test;
		}
    }
}