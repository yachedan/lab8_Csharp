using System;
using System.Collections.Generic;
namespace task3
{
    public class Car : IComparable, IComparer<Car>
    {
        public string Name{get; set;}
        public int Cost{get; set;}
        public int Power{get; set;}

        public int CompareTo(Object obj){
            if (obj == null) return 1;

            Car otherCar = obj as Car;
            if (obj != null)
                return this.Cost.CompareTo(otherCar.Cost);
            else
                throw new ArgumentException("Object is not a Temperature");
        }
        public int Compare(Car x, Car y)
        {
            if (x.Cost.CompareTo(y.Cost) != 0)
            {
                return x.Cost.CompareTo(y.Cost);
            }
            else if (x.Power.CompareTo(y.Power) != 0)
            {
                return x.Power.CompareTo(y.Power);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString(){
            return $"Car=(Name: {Name}, Cost: {Cost}, Power: {Power})";
        }

    }
}