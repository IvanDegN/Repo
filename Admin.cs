using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp25
{
    internal class Admin : User
    {
        public bool isCanEdit;
        //public string role;

        public Admin(string login, string password, string role, bool isCanEdit) : 
            base(login, password, role)
        {
            this.isCanEdit = isCanEdit;
            
        }
    }
}
