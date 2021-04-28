using System;
namespace task1
{
    public class City : Place
    {
        public string Name {get; set;}
        public int Aglom{get; set;}

        public City(){
            _area = 0;
            _pop = 0;
            Name = null;
            Aglom = 0;
        }
        public City(double area, int pop, string name, int aglom){
            _area = area;
            _pop = pop;
            Name = name;
            Aglom = aglom;
        }
        public override string ToString()
        {
            return $"City=(Area: {_area}, Population: {_pop}, Name: {Name}, Agglomeration: {Aglom})";
        }
        public override void GetCity()
        {
            Console.WriteLine(this);
        }
        public override void GetVillage()
        {
            Console.WriteLine("Not a village.");
            throw new NotImplementedException();
        }
    }
}