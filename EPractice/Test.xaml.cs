using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EPractice
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        NavigationService nav;
        System.Timers.Timer tm;
        TimeSpan countDown;
        ObservableCollection<Question> q = new ObservableCollection<Question>() 
        { 
           
         new Question{no=1,answer="N/A"},new Question{no=2,answer="N/A"},new Question{no=3,answer="N/A"},
        new Question{no=4,answer="N/A"},new Question{no=5,answer="N/A"},new Question{no=6,answer="N/A"},new Question{no=7,answer="N/A"},new Question{no=8,answer="N/A"},new Question{no=9,answer="N/A"},
        new Question{no=10,answer="N/A"},new Question{no=11,answer="N/A"},new Question{no=12,answer="N/A"},new Question{no=13,answer="N/A"},new Question{no=14,answer="N/A"},new Question{no=15,answer="N/A"},
        new Question{no=16,answer="N/A"},new Question{no=17,answer="N/A"},new Question{no=18,answer="N/A"},new Question{no=19,answer="N/A"},new Question{no=20,answer="N/A"},new Question{no=21,answer="N/A"},
        new Question{no=22,answer="N/A"},new Question{no=23,answer="N/A"},new Question{no=24,answer="N/A"},new Question{no=25,answer="N/A"},new Question{no=26,answer="N/A"},new Question{no=27,answer="N/A"}
        ,new Question{no=28,answer="N/A"},new Question{no=29,answer="N/A"},new Question{no=30,answer="N/A"},new Question{no=31,answer="N/A"},new Question{no=32,answer="N/A"},new Question{no=33,answer="N/A"}
        ,new Question{no=34,answer="N/A"},new Question{no=35,answer="N/A"},new Question{no=36,answer="N/A"},new Question{no=37,answer="N/A"},new Question{no=38,answer="N/A"},new Question{no=39,answer="N/A"}
        ,new Question{no=40,answer="N/A"}};
        public Test()
        {
            this.ShowsNavigationUI = false;
            InitializeComponent();
            questionsGrid.ItemsSource = q;
            countDown = new TimeSpan(0,40,0);
            tm = new System.Timers.Timer(1000);
            tm.Elapsed += tm_Elapsed;
            tm.Start();

        }

        void tm_Elapsed(object sender, ElapsedEventArgs e)
        {
            countDown = countDown - TimeSpan.FromSeconds(1);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate()
            {
                timertxt.Text = "Time: " + countDown.ToString();
            });
        }

        private void quit_eventhandler(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
