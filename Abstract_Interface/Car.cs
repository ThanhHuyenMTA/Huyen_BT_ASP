using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Car:Vehicles
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car() { }
        public Car(string maker, string model, double price, string color)
            : base(maker, model, price)
        {
            this.color = color;
        }
        public override void input()
        {
            base.input();
            Console.Write("Input color: "); color = Console.ReadLine();
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("; {0}", color);
        }
    }
}
