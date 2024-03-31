using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third.Entities
{
    internal class RoledEntity: BaseEntity
    {
        protected Roles Role { get; set; }
        protected string GetNoRightsText()
        {
            return "У вас нет прав на получение/изменение этих данных";
        }
        public bool CheckRole(Roles userRole)
        {
            return userRole == Roles.all || userRole == Role;
        }
    }
}
