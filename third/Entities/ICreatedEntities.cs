using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third.Entities
{
    internal interface ICreatedEntities
    {
        public TimeSpan GetElapsedTimeFromCreation(DateTime createdTime)
        {
            return DateTime.Now - createdTime;
        }
    }
}
