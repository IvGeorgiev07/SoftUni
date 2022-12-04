using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project3_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();


            string[] input = Console.ReadLine().Split(": ");

            while (input[0] != "Log out")
            {
                if(input[0] == "New follower")
                {
                    string username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        Follower follower = new Follower(0, 0);
                        followers.Add(username, follower);
                    }   
                }
                else if(input[0] == "Like")
                {
                    string username = input[1];
                    int like = int.Parse(input[2]);

                    if (!followers.ContainsKey(username))
                    {
                        Follower follower = new Follower(like, 0);
                        followers.Add(username, follower);
                    }
                    else
                    {
                        followers[username].Likes += like;
                    }
                }
                else if (input[0] == "Comment")
                {
                    string username = input[1];

                    if (!followers.ContainsKey(username))
                    {
                        Follower follower = new Follower(0, 1);
                        followers.Add(username, follower);
                    }
                    else
                    {
                        followers[username].Comments += 1;
                    }
                }
                else if (input[0] == "Blocked")
                {
                    string username = input[1];

                    if (followers.ContainsKey(username))
                    {
                        followers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist."
);
                    }
                }

                input = Console.ReadLine().Split(": ");
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach(var (username, likesComm) in followers)
            {
                Console.WriteLine($"{username}: {likesComm.Likes+likesComm.Comments}");
            }

        }
    }







    internal class Follower
    {
        public Follower(int likes, int comments)
        {
            Likes = likes;
            Comments = comments;
        }

        public int Likes { get; set; }
        public int Comments { get; set; }

    }
}