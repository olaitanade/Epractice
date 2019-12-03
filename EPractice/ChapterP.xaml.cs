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
    /// Interaction logic for ChapterP.xaml
    /// </summary>
    public partial class ChapterP : Page
    {
        NavigationService nav;
        Singleton store = Singleton.Instance;
        public ChapterP()
        {
            this.ShowsNavigationUI = false;
            InitializeComponent();
           
        }

        private void subjects_Selected(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            store.selectedChapIndex = chapterCombo.SelectedIndex;
            nav.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            chapterCombo.ItemsSource = store.subjects[store.SelectedIndex].chapter;
            
        }

        private void backbtn_eventhdler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("FrontPage.xaml", UriKind.RelativeOrAbsolute));
        }
        

       
    }
}
