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

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model;
        private Presenter presenter;
        //  List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();

            model = new Model();
            presenter = new Presenter(model);

            //User user = new User("loli", "pass");
            //users.Add(user);

            ///users.Add(new User() { login = TbLogin.Text, password = TbPassword.Text });
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.model = this.presenter.Login(TbLogin.Text, TbPassword.Text); // send data to 
                                                                              // presenter and
                                                                              // get new model
            Update(); // update UI
            ListUsers list = new ListUsers();
            list.Show();
            //foreach(User user in users)
            //{
            //    if(user.login == TbLogin.Text && user.password == TbPassword.Text)
            //    {
            //        TbWelcome.Text = "hiiii";
            //    }
            //}
        }

        private void Update()
        {
            TbWelcome.Text = this.model.Message; // message from model
        }
    }
}
