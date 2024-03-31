using System;
using third;
using third.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Controller controller = new ();
        Post[] posts = controller.GetPosts();
        Comment[] comments = controller.GetComments();
        Event[] events = controller.GetEvents();
        User[] users = controller.GetUsers();
        Random rand = new();

        for (int i = 0; i < posts.Length; i++)
        {
            Console.WriteLine($"Post {i} - ID - {posts[i].GetID()}");
        }
        for (int i = 0; i < comments.Length; i++)
        {
            Console.WriteLine($"Comment {i} - ID - {comments[i].GetID()}");
        }
        for (int i = 0; i < events.Length; i++)
        {
            Console.WriteLine($"Event {i} - ID - {events[i].GetID()}");
        }
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"User {i} - ID - {users[i].GetID()}, Role - {users[i].GetRole()}");
        }

        Console.WriteLine("*************************************");

        for (int i = 0; i < users.Length; i++)
        {
            User user = users[i];
            Console.WriteLine($"User {user.GetID()}");
            for (int j = 0; j < events.Length; j++)
            {
                try
                {
                    string description = events[j].GetDescription(user.GetRole());
                    Console.WriteLine($"Запросил описание Event'a {events[j].GetID()}, description - {description}");
                } catch (Exception e)
                {
                    Console.WriteLine($"Не может получить данные Event'a {events[j].GetID()}, ошибка - {e.Message}");
                }
            }

            for (int j = 0; j < posts.Length; j++)
            {
                try
                {
                    string content = posts[j].GetContent(user.GetRole());
                    Console.WriteLine($"Запросил контент Post'a {posts[j].GetID()}, content - {content}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Не может получить данные Post'a {posts[j].GetID()}, ошибка - {e.Message}");
                }
            }

            for (int j = 0; j < comments.Length; j++)
            {
                try
                {
                    string content = comments[j].GetContent(user.GetRole());
                    Console.WriteLine($"Запросил контент Comment'a {comments[j].GetID()}, content - {content}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Не может получить данные Comment'a {comments[j].GetID()}, ошибка - {e.Message}");
                }
            }

            Console.WriteLine();
        }
    }
}