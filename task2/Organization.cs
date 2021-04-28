using System;
namespace task2
{
    public class Organization : Client
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public double Share {get; set;}
        public Organization()
        {
            Id = null;
            Name = null;
            Balance = 0;
            Share = 0;
        }
        public Organization(string id, string name, int balance, double share)
        {
            Id = id;
            Name = name;
            Balance = balance;
            Share = share;
        }
        public double GetCredit(int initial, double percent)
        {
            Balance += (int) (initial + initial * percent/Share);
            return (initial + initial * percent/Share);
        }
        public override string ToString()
        {
            return $"Organization=(Id: {Id}, Name: {Name}, Balance: {Balance}, Share: {Share})";
        }
        public void GetInfo()
        {
            Console.WriteLine(this);
        }
    }
}