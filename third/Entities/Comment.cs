namespace third.Entities
{
    internal class Comment : RoledEntity, ICreatedEntities
    {
        private string AuthorID { get; set; }
        private string Content { get; set; }

        public Comment(string authorID, string content, Roles role)
        {
            Random rand = new();
            ID = "CommentID-" + rand.Next(1, 10000).ToString();
            AuthorID = authorID;
            Content = content;
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
    }
}
