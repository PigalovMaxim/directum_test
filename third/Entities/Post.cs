namespace third.Entities
{
    internal class Post : RoledEntity, ICreatedEntities
    {
        private string AuthorID { get; set; }
        private string Content { get; set; }
        private string Preview { get; set; }

        public Post(string authorID, string content, string preview, Roles role)
        {
            Random rand = new();
            ID = "PostID-" + rand.Next(1, 10000).ToString();
            AuthorID = authorID;
            Content = content;
            Preview = preview;
            Role = role;
        }

        public string GetAuthorID(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return AuthorID;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetAuthorID(Roles userRole, string authorID)
        {
            if (CheckRole(userRole))
            {
                AuthorID = authorID;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }

        public string GetContent(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return Content;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetContent(Roles userRole, string content)
        {
            if (CheckRole(userRole))
            {
                Content = content;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }

        public string GetPreview(Roles userRole)
        {
            if (CheckRole(userRole))
            {
                return Preview;
            }

            throw new Exception(GetNoRightsText());
        }

        public void SetPreview(Roles userRole, string preview)
        {
            if (CheckRole(userRole))
            {
                Preview = preview;
                Changedatetime = DateTime.Now.ToString();
                return;
            }

            throw new Exception(GetNoRightsText());
        }
    }
}