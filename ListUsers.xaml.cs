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
using System.Windows.Shapes;

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для ListUsers.xaml
    /// </summary>
    public partial class ListUsers : Window
    {
        public ListUsers()
        {
            InitializeComponent();

            //List<User> list = new List<User> // создание списка пользователей
            // {
            //     new User("jjie", "pass", "user"),
            //     new User("rre3", "pass1", "user"),
            //     new User("vvde", "pass2", "user"),
            //     new User("bfd", "pass3", "user"),
            //     new User("Admin", "Admin", "admin")
            // };

            Model model = new Model();
            // List<User> list = model.CreateUser();
            DGrid.ItemsSource = model.GetUsers(); // получение списка пользователей для отображения
                                                  // в таблице
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
