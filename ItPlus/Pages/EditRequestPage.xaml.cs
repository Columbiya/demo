using ItPlus.Model;
using ItPlus.Services;
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

namespace ItPlus.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditRequestPage.xaml
    /// </summary>
    public partial class EditRequestPage : Page
    {
        Request _req;

        public EditRequestPage(Request requestToEdit)
        {
            InitializeComponent();

            _req = requestToEdit;
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Изменить данные?", "Изменение данных заявки", MessageBoxButton.YesNo);

            if (messageBoxResult != MessageBoxResult.OK)
            {
                return;
            }

            var request = Appcontext.ctx.Requests.Where(x => x.IdRequest == _req.IdRequest).FirstOrDefault();
            request.DescriptionProblem = descrip.Text;
            request.ResponseEemployee = (employee.SelectedItem as User).IdUsers;
            request.Status = (status.SelectedItem as RequestStatus).IdrequestStatus;

            Appcontext.ctx.SaveChanges();

        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            code.Text = _req.IdRequest.ToString();
            date.Text = _req.DateAdd.ToString();
            model.Text = _req.ModelDevice.ToString();
            descrip.Text = _req.DescriptionProblem.ToString();

            var employees = Appcontext.ctx.Users.Where(u => u.RoleNavigation.IdRole == Convert.ToInt32(RoleService.Roles.Mechanic)).ToList();
            employee.ItemsSource = employees;
            employee.SelectedIndex = employees.FindIndex(e => e.IdUsers == _req.ResponseEemployee);

            var statuses = Appcontext.ctx.RequestStatuses.ToList();
            status.ItemsSource = statuses;
            status.SelectedIndex = statuses.FindIndex(e => e.IdrequestStatus == _req.Status);
        }
    }
}
