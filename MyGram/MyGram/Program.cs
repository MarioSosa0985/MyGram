using System;
using MyGram.Models;

namespace MyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersDTO myUser = new UsersDTO();
            myUser.UserId = 1;
            myUser.UserName = "Mario Sosa";

            Console.WriteLine(myUser.UserId);
            Console.WriteLine(myUser.UserName);
        }
    }
}