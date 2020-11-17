using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>();


           //intList.Add(2);

            intList.AddRange(new List<int>
            {
                1, 3, 5
            });
        }
    }
}
