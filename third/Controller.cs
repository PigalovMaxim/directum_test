using third.Entities;

namespace third
{
    internal class Controller
    {
        private Post[] Posts { get; set; }
        private Comment[] Comments { get; set; }
        private Event[] Events { get; set; }
        private User[] Users { get; set; }

        public Controller()
        {
            Random rand = new();
            Users = new User[3];
            Posts = new Post[4];
            Comments = new Comment[4];
            Events = new Event[4];
            Roles[] allRoles = [Roles.all, Roles.admin, Roles.user];

            for (int i = 0; i < Users.Length; i++)
            {
                Users[i] = new User($"Какое-то имя {i}", i % 2 == 0 ? Roles.user : Roles.admin);
            }

            for (int i = 0; i < Posts.Length; i++)
            {
                User author = Users[rand.Next(Users.Length)];
                Comments[i] = new Comment(author.GetID(), $"Какой-то контент {i}", allRoles[rand.Next(allRoles.Length)]);
                Posts[i] = new Post(author.GetID(), $"Какой-то контент {i}", $"Какое-то превью {i}", allRoles[rand.Next(allRoles.Length)]);
                Events[i] = new Event($"Какое-то описание {i}", rand.Next(150), 150, allRoles[rand.Next(allRoles.Length)]);
            }
        }

        public Post[] GetPosts()
        {
            return Posts;
        }

        public Comment[] GetComments()
        {
            return Comments;
        }

        public Event[] GetEvents()
        {
            return Events;
        }

        public User[] GetUsers()
        {
            return Users;
        }
    }
}
