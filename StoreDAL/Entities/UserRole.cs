using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("user_roles")]
    public class UserRole:BaseEntity
    {
        [Column("user_role_name")]
        public string RoleName { get; set; }
        public virtual IList<User> User { get; set; }
        public UserRole() { }
        public UserRole(int id, string roleName) : base(id)
        {
            this.RoleName = roleName;
        }
    }
}
