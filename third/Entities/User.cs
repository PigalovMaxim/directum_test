using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third.Entities
{
    internal class User : BaseEntity
    {
        private string Name { get; set; }
        private Roles Role { get; set; }

        public User(string name, Roles role)
        {
            Name = name;
            Random rand = new();
            ID = "UserID-" + rand.Next(1, 10000).ToString();
            Role = role;
        }

        public string GetName()
        {
            return Name;
        }

        public Roles GetRole()
        {
            return Role;
        }
    }
}
