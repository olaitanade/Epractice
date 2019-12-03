using EPractice.Model;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        NavigationService nav;
        Singleton store = Singleton.Instance;
        int temp = 0;
        int pgNo = 0;
        List<string> Picuri = new List<string>();
        public Page1()
        {
            this.ShowsNavigationUI = false;
            InitializeComponent();
            
        }

        private void home_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("FrontPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void mcq_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("Mcq.xaml", UriKind.RelativeOrAbsolute));
        }

        private void test_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("Test.xaml", UriKind.RelativeOrAbsolute));
        }

        private void help_eventhandler(object sender, RoutedEventArgs e)
        {
            //nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void report_eventhandler(object sender, RoutedEventArgs e)
        {
            //nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (temp >= 0 && temp < pgNo)
            {
                if (temp != 0) temp -= 1;
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(Picuri[temp], UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                synopsisImg.Source = src;
                pgTxt.Text = (temp + 1).ToString();
            }
        }

        private void forwardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (temp > -1 && temp <= pgNo-1)
            {
                if (temp != pgNo-1) temp += 1;
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(Picuri[temp], UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                synopsisImg.Source = src;
                pgTxt.Text = (temp + 1).ToString();
                
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pgNo = store.subjects[store.SelectedIndex].chapter[store.selectedChapIndex].pages.Count;
            Picuri = store.subjects[store.SelectedIndex].chapter[store.selectedChapIndex].pages;
            if (pgNo != 0)
            {
                BitmapImage src = new BitmapImage();
                src.BeginInit();

                src.UriSource = new Uri(Picuri[temp], UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                synopsisImg.Source = src;
            }
            
            

        }

        private void backbtn_eventhdler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("ChapterP.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
