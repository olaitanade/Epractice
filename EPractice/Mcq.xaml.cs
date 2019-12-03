using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EPractice
{
    /// <summary>
    /// Interaction logic for Mcq.xaml
    /// </summary>
    public partial class Mcq : Page
    {
        NavigationService nav;
        public Mcq()
        {
            this.ShowsNavigationUI = false;
            InitializeComponent();
        }

        private void home_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("FrontPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void test_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("Test.xaml", UriKind.RelativeOrAbsolute));
        }

        private void report_eventhandler(object sender, RoutedEventArgs e)
        {
            //nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new System.Uri("Report.xaml", UriKind.RelativeOrAbsolute));
        }

        private void help_eventhandler(object sender, RoutedEventArgs e)
        {
            //nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new System.Uri("Help.xaml", UriKind.RelativeOrAbsolute));
        }

        private void backbtn_eventhdler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
