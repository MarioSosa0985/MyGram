using System;
using MyGram.Models;

namespace MyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(var i=1;i<=20;i++)
            {
                result = result + i;
            }

            Console.WriteLine(result);
        }
    }
}