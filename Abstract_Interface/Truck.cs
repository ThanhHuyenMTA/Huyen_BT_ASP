using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Truck:Vehicles
    {
        private int truckload;

        public int Truckload
        {
            get { return truckload; }
            set { truckload = value; }
        }
        public Truck()
        {

        }
        public Truck(string maker,string model,double price,int truckload):base(maker,model,price)
        {
            this.truckload = truckload;
        }
        public override void input()
        {
            base.input();
            Console.Write("Input truckload: "); truckload =Int32.Parse(Console.ReadLine());
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("; {0} kg", truckload);
        }
    }
}
