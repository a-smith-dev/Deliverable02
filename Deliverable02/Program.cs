using System;

namespace Deliverable02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", message = "";
            int checksum = 0;

            Console.Write("What is your message? ");
            input = Console.ReadLine();
            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                int u = (int)input[i];
                checksum += u;
                message += u - 64;
                if (i != (input.Length - 1))
                {
                    message += "-";
                }
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
