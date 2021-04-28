using System;
namespace task2
{
    public class Investor : Client
    {
        public string Id{get; set;}
        public string Name{get; set;}
        public int Balance{get; set;}
        public int Deposit{get; set;}

        public Investor(){
            Id = null;
            Name = null;
            Balance = 0;
            Deposit = 0;
        }
        public Investor(string id, string name, int balance, int Deposit){
            id = id;
            Name = name;
            Balance = balance;
            Deposit = Deposit;
        }
        public double GetCredit(int initial, double percent){
            Balance += (int) (initial + initial * percent);
            return (initial + initial * percent);
        }
        public override string ToString()
        {
            return $"Investor=(Id: {Id}, Name: {Name}, Balance: {Balance}, Deposit: {Deposit})";
        }
        public void GetInfo(){
            Console.WriteLine(this);
        }
    }
}