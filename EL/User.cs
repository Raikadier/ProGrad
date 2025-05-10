using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal abstract class User
    {
        private int id {  get; set; }
        private string name { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string role { get; set; }

        public User() { }   

        public User(int id, string name, string lastName, string email, string password, string role)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public override string ToString()
        {
            return base.ToString() + $"{name};{lastName};{email};{password};{role}";
        }
    }
}
