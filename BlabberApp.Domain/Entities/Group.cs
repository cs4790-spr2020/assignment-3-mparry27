using System;
using System.Collections.Generic;

namespace BlabberApp.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public Group(){}

        public Group(string name, List<User> users)
        {
            this.Name = name;
            this.Users = users;
        }
    }
}