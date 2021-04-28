using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Investor("1","Doge", 123456, 10000);
            client.GetInfo();
            Console.WriteLine(client.GetCredit(1250,0.05));
        }
    }
}
