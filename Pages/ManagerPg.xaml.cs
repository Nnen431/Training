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
    public partial class ManagerPg : Page
    {
        public ManagerPg()
        {
            InitializeComponent();
            Loaded += ManagerPg_Loaded;
            LoadBooks();
        }

        private void ManagerPg_Loaded(object sender, RoutedEventArgs e)
        {
            var currentUser = MainWindow.CurrentUser;
            if (currentUser != null)
            {             
                    var userInfo = dbEntities.GetContext().Info.FirstOrDefault(info => info.Id == currentUser.UserId);
                    if (userInfo != null)
                    {
                        UserInfoTextBlock.Text = $"Role: {currentUser.Role}, Name: {userInfo.FName} {userInfo.LName}";
                    }
                    else
                    {
                        UserInfoTextBlock.Text = $"Role: {currentUser.Role}, Name: Not Found";
                    }              
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = dbEntities.GetContext();

            var newBook = new Books
            {
                Name = BookName.Text,
                PublishedYear = BookYear.Text,
                Author = BookAuthor.Text,
            };
            context.Books.Add(newBook);
            context.SaveChanges();
            MessageBox.Show("Book Added!");
        }

        private void LoadBooks()
        {
            BooksGrid.ItemsSource = dbEntities._context.Books.ToList();
        }
    }
}
