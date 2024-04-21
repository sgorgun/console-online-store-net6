﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("users")]
    public class User:BaseEntity
    {
        [Column("first_name")]
        public string Name { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("login")]
        public string Login { get; set; }
        
        [Column("Password")]
        public string Password { get; set; }
        
        [ForeignKey("Role")]
        [Column("user_role_id")]
        public int RoleId { get; set; }

        public UserRole Role { get; set; }
        public virtual IList<CustomerOrder> Order { get; set; }
        public User() : base() { }

        public User(int id, string name, string lastName, string login, string password, int roleId) : base(id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
            this.RoleId = roleId;
        }
    }
}
