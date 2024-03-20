using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    internal class User
    {
        private string login;
        private string password;
        private string role;

        public User(string login, string password, string role) // создание конструктора
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public string Login // геттер для получения логина
        {
            get
            {
                return this.login;
            }
        }

        public string Password // геттер для получения пароля
        {
            get
            {
                return this.password;
            }
        }

        public string Role
        {
            get
            {
                return this.role;
            }
        }

        
    }
}
