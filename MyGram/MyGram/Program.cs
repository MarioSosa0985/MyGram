using System;

namespace MyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Users myUser = new Users();
            myUser.UserId = 1;
            myUser.UserName = "Mario Sosa";

            Console.WriteLine(myUser.UserId);
            Console.WriteLine(myUser.UserName);
        }
    }
}

public class Users
{
    public int UserId { get; set; }
    public string UserName { get; set; }
}

public class Roles
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
}

public class Images
{
    public int ImageId { get; set; }
    public string ImagePath { get; set; }
}

public class Posts
{
    public int PostId { get; set; }
    public string PostDate { get; set; }
}

public class Comments
{
    public int CommentId { get; set; }
    public string TheComment { get; set; }
}