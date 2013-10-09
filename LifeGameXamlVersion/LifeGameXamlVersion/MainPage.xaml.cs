using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LifeGameXamlVersion.Resources;

namespace LifeGameXamlVersion
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private void ContentPanel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse elipse=new Ellipse();
            elipse.Height = 20;
            elipse.Width = 20;
            elipse.Fill = Foreground;
            elipse.SetValue(Canvas.LeftProperty,e.GetPosition(ContentPanel).X);
            elipse.SetValue(Canvas.TopProperty, e.GetPosition(ContentPanel).Y);

            this.Dispatcher.BeginInvoke(() =>
            {
                ContentPanel.Children.Add(elipse);
                elipse.Visibility = Visibility.Visible;

            });

        }
    }
}