using System;
using System.Collections.Generic;

namespace BinaryNumbersQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter #");
            Queue<int> binaryQ = new Queue<int>();
            binaryQ.Enqueue(1);
            binaryQ.Enqueue(0);

            if (!int.TryParse(Console.ReadLine(), out int userNum))
            {
                switch (userNum)
                {
                    //case = 0:

                            
                }
            }
        }

       
    }
}
