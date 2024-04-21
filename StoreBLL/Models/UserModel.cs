using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class UserModel : AbstractModel
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public UserModel(int id, string name, string lastName, string login, string password, int roleId) : base(id)
        {
            this.UserName = name;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
            this.RoleId = roleId;
        }

        public override string ToString()
        {
            return $"Id:{Id} {UserName}";
        }
    }
}