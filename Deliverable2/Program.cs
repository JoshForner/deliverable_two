using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your message? ");
            string input = Console.ReadLine();
            string input1 = input.ToUpper();
            int total = 0;

            Console.Write("Your encoded message is ");
            for (int i = 0; i < input1.Length; i++)
            {
                char c = input1[i];
                int message = c - 64;
                Console.Write(message + "-");
            }
            Console.WriteLine();
            Console.Write("Message checksum is ");
            for (int i = 0; i < input1.Length; i++)
            {
                
                char c = input1[i];
                total += c;
                int checksum = total;
                Console.Write(checksum);
            }
        }
    }
}
