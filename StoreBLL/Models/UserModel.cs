using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class UserModel : AbstractModel
    {
        public string UserName { get; set; }
        public UserModel(int id, string userName) : base(id)
        {
            this.Id = id;
            this.UserName = userName;
        }
        public override string ToString()
        {
            return $"Id:{Id} {UserName}";
        }
    }
}