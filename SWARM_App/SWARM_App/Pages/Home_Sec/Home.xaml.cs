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
        public Home()
        {
            InitializeComponent();
            now = DateTime.Now.ToLocalTime();
            currentTime = now.Date.ToString("MM / dd / yyyy");//(string.Format("{0}", now));
            TimeName.Text = currentTime;
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