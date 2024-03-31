using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third.Entities
{
    internal abstract class BaseEntity
    {
 
        protected string ID { get; set; }
        protected string Createdatetime { get; } = DateTime.Now.ToString();
        protected string Changedatetime { get; set; } = DateTime.Now.ToString();

        public string GetID()
        {
            return ID;
        }
    }
}
