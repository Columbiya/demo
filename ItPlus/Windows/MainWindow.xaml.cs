using ItPlus.Helpers;
using ItPlus.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItPlus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PageNavigator.MainFrame = MainFrame;
            PageNavigator.MainFrame.Navigate(new AuthPage());
            PageNavigator.MainFrame.Navigated += HandleGoBack;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PageNavigator.MainFrame.CanGoBack)
            {
                PageNavigator.MainFrame.GoBack();
            }

            HandleGoBack(sender, null);
        }

        private void HandleGoBack(object sender, NavigationEventArgs e)
        {
            if (!PageNavigator.MainFrame.CanGoBack)
            {
                GoBackBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                GoBackBtn.Visibility = Visibility.Visible;
            }
        }
    }
}