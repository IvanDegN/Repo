using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    internal class Presenter
    {
        private Model model; // связь с моделью

        public Presenter(Model model)
        {
            this.model = model;
        }

        public Model Login(string login, string password) // get data from view
        {
            login = login.Trim(); // обработка полученной информации
            password = password.Trim();
            this.model.Login(login, password); // обновление модели
            return this.model; // передача обновлённой модели
        }

        public Model CreateUser(string login, string password, string role)
        {


            return this.model;
        }

        //public Model Login(string login, string password, bool isCanEdit) // get data from view
        //{
        //    login = login.Trim(); // обработка полученной информации
        //    password = password.Trim();
        //    this.model.Login(login, password, isCanEdit); // обновление модели
        //    return this.model; // передача обновлённой модели
        //}
    }
}
