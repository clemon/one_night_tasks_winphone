using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using OneNightTasks.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace OneNightTasks
{
    public partial class TaskDetails : PhoneApplicationPage
    {
        const string jobsUrl = @"http://hackathonshit.alienreader.org/api/jobs/";
        int index;

        public TaskDetails()
        {
            
            InitializeComponent();
            TitleText.Text = "";
            DetailText.Text = "";
            UsernameText.Text = "";
            getData();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (this.NavigationContext.QueryString.ContainsKey("index"))
            {
                index = Convert.ToInt32(this.NavigationContext.QueryString["index"]);
            }
        }

        private void getData()
        {
            var allTasks = App.allTasks;
            
            Debug.WriteLine(index +"    "+ App.allTasks[index].Title);
            foreach (var task in allTasks)
            {
                if (task.Title == App.allTasks[App.index].Title)
                {
                    PriceText.Text = "$"+task.Price;
                    TitleText.Text = task.Title;
                    DetailText.Text = task.description;
                    UsernameText.Text = task.Owner_name;
                }
            }
        }

        private void BidButton_Click(object sender, RoutedEventArgs e)
        {
            BidButton.Content = "Bid Placed!";
        }
    }
}