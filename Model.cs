using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    
    internal class Model
    {
        private List<User> users; // создание полей
      //  private List<Admin> admins;
        private User isLogin;
       // private Admin isLoginAdmin;

        public Model()
        {
            users = new List<User> // создание списка пользователей
            {
                new User("jjie", "pass", "user"),
                new User("rre3", "pass1", "user"),
                new User("vvde", "pass2", "user"),
                new User("bfd", "pass3", "user"),
                new User("Admin", "Admin", "admin")
            };

            isLogin = null; // сообщение после ввода логина и пароля

            //admins = new List<Admin>
            //{
            //    new Admin("Admin","Admin",true, "admin")
            //};
            
        }

        public void Login(string login, string pass) // проверка входа
        {
            bool isLogin = false;

            foreach(User user in this.users)
            {
                if(user.Login == login && user.Password == pass)
                {
                    this.isLogin = user; // Обновление модели
                    isLogin = true;
                    break;
                }
            }

            if (!isLogin)
            {
                this.isLogin = null;
            }
        }

        public List<User> GetUsers() // возвращает список пользователей
        {
            return users; 
            
        }

        //public void Login(string login, string pass, bool isCanEdit)
        //{
        //    bool isLoginAdmin = false;

        //    foreach (Admin admin in this.admins)
        //    {
        //        if (admin.Login == login && admin.Password == pass && admin.isCanEdit)
        //        {
        //            this.isLoginAdmin = admin; // Обновление модели
        //            isLoginAdmin = true;
        //            break;
        //        }
        //    }

        //    if (!isLoginAdmin)
        //    {
        //        this.isLoginAdmin = null;
        //    }
        //}

        public string Message // cообщение после авторизации
        {
            get
            {
                //if (this.isLoginAdmin != null)
                //{
                //    return $"Hiiii!!! your login is {this.isLogin.Login} your role is {this.isLoginAdmin.role}";
                //}

                //else if  (this.isLogin != null)
                //{
                //    return $"Hiiii!!! your login is {this.isLogin.Login}";
                //}
                //else
                //{
                //    return "Wrong password or login";
                //}

                return this.isLogin != null ? $"hiiii {this.isLogin.Login} you role is {this.isLogin.Role}" : "wrong login or password";

               // return this.isLogin != null ?  \n role is {this.isLoginAdmin.role}" : ;
            }
        }

        //public string MessageAdmin
        //{
        //    get
        //    {

        //    }
        //}
    }
}
