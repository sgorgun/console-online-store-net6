using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class UserRoleModel : AbstractModel
    {
        public string RoleName { get; set; }
        public UserRoleModel(int id, string roleName):base(id)
        {
            this.Id = id;
            this.RoleName = roleName;
        }
        public override string ToString()
        {
            return $"Id:{Id} {RoleName}";
        }
    }
}
