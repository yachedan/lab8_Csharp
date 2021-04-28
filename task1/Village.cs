using System;
namespace task1
{
    public class Village : Place
    {
        public string Name{get; set;}
        public string Region{get; set;}

        public Village(){
            _area = 0;
            _pop = 0;
            Name = null;
            Region = null;
        }
        public Village(double area, int pop, string name, string region){
            _area = area;
            _pop = pop;
            Name = name;
            Region = region;
        }
        public override string ToString()
        {
            return $"Village=(Area: {_area}, Population: {_pop}, Name: {Name}, Region: {Region})";
        }
        public override void GetVillage()
        {
            Console.WriteLine(this);
        }
        public override void GetCity()
        {
            Console.WriteLine("Not a city.");
            throw new NotImplementedException();
        }
        
    }
}