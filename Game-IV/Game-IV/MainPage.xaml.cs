using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Game_IV.Resources;
using Microsoft.Phone.Tasks;

namespace Game_IV
{
    public partial class MainPage : PhoneApplicationPage
    {
        static bool appLoaded = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (appLoaded == false)
            {
                appLoaded = true;

                NavigationService.RemoveBackEntry();

                WebBrowserTask webTask = new WebBrowserTask();
                webTask.Uri = new Uri("http://www.game-iv.com");
                webTask.Show();
            }

            Application.Current.Terminate();
        }
    }
}