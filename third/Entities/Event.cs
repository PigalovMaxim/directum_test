using System.Data;

namespace third.Entities
{
    internal class Event : RoledEntity
    {
        private string Description { get; set; }
        private int CountOfMembers { get; set; }
        private int NecessaryCountOfMembers { get; set; }

        public Event(string description, int countOfMembers, int necessaryCountOfMembers, Roles role)
        {
            Random rand = new();
            ID = "EventID-" + rand.Next(1, 10000).ToString();
            Description = description;
            CountOfMembers = countOfMembers;
            NecessaryCountOfMembers = necessaryCountOfMembers;
            Role = role;
        }

        public string GetDescription(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return Description;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetDescription(Roles userRole, string description)
        {
            if (CheckRole(userRole))
            {
                Description = description;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }

        public int GetCountOfMembers(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return CountOfMembers;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetCountOfMembers(Roles userRole, int countOfMembers)
        {
            if (CheckRole(userRole))
            {
                CountOfMembers = countOfMembers;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }
        public int GetNecessaryCountOfMembers(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return NecessaryCountOfMembers;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetNecessaryCountOfMembers(Roles userRole, int necessaryCountOfMembers)
        {
            if (CheckRole(userRole))
            {
                NecessaryCountOfMembers = necessaryCountOfMembers;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }

        public bool WillTheEvent()
        {
            return CountOfMembers == NecessaryCountOfMembers;
        }
    }
}
