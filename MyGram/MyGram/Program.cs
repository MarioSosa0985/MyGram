using System;
using System.Collections.Generic;
using MyGram.Models;

namespace MyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 54324;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;

            for(var i=0;i< myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }

            List<string> myList = new List<string>();
            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");
            myList.Add("5");
            myList.Add("6");
            myList.Add("7");
            myList.Add("8");
            myList.Add("9");
            myList.Add("10");

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}