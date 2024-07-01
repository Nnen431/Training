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
using Test123.Resourses.Db;

namespace Test123
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = dbEntities.GetContext().Users.FirstOrDefault(u => u.Login == LoginTb.Text && u.Password == PasswordPb.Password);
            if (user != null)
            {
                MainWindow.CurrentUser = user;
                if (user.Role.Contains("manager"))
                {
                    NavigationService.Navigate(new ManagerPg());
                }
                else
                {
                    NavigationService.Navigate(new AdminPg());
                }
            }
            else
            {
                MessageBox.Show("Incorrect password or login. Try again!");
            }
        }

    }
}
