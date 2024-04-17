using ItPlus.Helpers;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string pass = password.Password;
            if(log==null || pass==null)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            var id = AuthService.Authorization(log, pass);

            if (id != -1)
            {
                var user = UserService.GetUserById(id);
                Appcontext.AuthUser = user;

                MessageBox.Show("Авторизация успешна!");
                PageNavigator.MainFrame.Navigate(new RequestListPage());
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
