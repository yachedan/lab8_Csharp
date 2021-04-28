using System;
using System.Linq;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            Place[] fakeData = new Place[10];
            for(int i = 0; i < 10; i++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                string name = new string(Enumerable.Repeat(chars, random.Next(3, 16))
                  .Select(s => s[random.Next(s.Length)]).ToArray());
                if(random.Next(1,3) == 1){
                    fakeData[i] = new Village(random.NextDouble()*(482.3-0.349)+0.349,random.Next(30,268000),name
                    , new string(Enumerable.Repeat(chars, random.Next(3, 20)).Select(s => s[random.Next(s.Length)]).ToArray()));
                    fakeData[i].GetVillage();
                }
                else{
                    fakeData[i] = new City(random.NextDouble() * (482.3 - 0.349) + 0.349, random.Next(30, 268000), name
                    , random.Next(1000,1000000));
                    fakeData[i].GetCity();
                }

            }
            int pop = 10000;
            Console.WriteLine("FIND RESULT: ");
            for (int i = 0; i < 10; i++)
            {
                if(fakeData[i].GetPop().ToString().Length == pop.ToString().Length)
                    Console.WriteLine(fakeData[i]);
            }

        }
    }
}
