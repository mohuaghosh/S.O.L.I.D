using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._3_Liskov_Substitution.a._Violation
{
    class Fruits
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine("Am an object of {0} color",fruit.GetColor());
        }
    }
    public class Fruit
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
