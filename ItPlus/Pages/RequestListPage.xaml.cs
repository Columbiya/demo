using ItPlus.Helpers;
using ItPlus.Model;
using ItPlus.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ItPlus.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestListPage.xaml
    /// </summary>
    public partial class RequestListPage : Page
    {
        ObservableCollection<Request> _requests = new ObservableCollection<Request>();
        public RequestListPage()
        {
            InitializeComponent();
        }
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            _requests.Clear();

            var req = Appcontext.ctx.Requests.ToList();

            foreach (var item in req)
            {
                _requests.Add(item);
            }

            requetlist.ItemsSource = _requests;

            LeaveRequest.Visibility = RoleService.CanLeaveRequest() ? Visibility.Visible: Visibility.Hidden;
        }

        private void ChangeReq(object sender, SelectionChangedEventArgs e)
        {
            if (Appcontext.AuthUser.Role == Convert.ToInt32(RoleService.Roles.Client))
            {
                return;
            }

            var selectedRequest = requetlist.SelectedItem as Request;

            if (selectedRequest == null)
            {
                return;
            }

            PageNavigator.MainFrame.Navigate(new EditRequestPage(selectedRequest));
        }

        private void poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = poisk.Text;

            if (!string.IsNullOrEmpty(search))
            {
                var req = Appcontext.ctx.Requests.Where(x => x.ModelDevice.Contains(search)).ToList();

                _requests.Clear();

                foreach (var item in req)
                {
                    _requests.Add(item);
                }
            }
            else
            {
                var req = Appcontext.ctx.Requests.ToList();

                _requests.Clear();

                foreach (var item in req)
                {
                    _requests.Add(item);
                }
            }

        }

        private void LeaveRequestButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
