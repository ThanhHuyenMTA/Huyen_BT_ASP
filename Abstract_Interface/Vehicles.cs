using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Vehicles:Interface_Vehicle
    {
        private String maker;

        public String Maker
        {
            get { return maker; }
            set { maker = value; }
        }
        private String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Vehicles() 
        {
            
        }
        public Vehicles(string maker,string model,double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }
        public virtual void input()
        {
            Console.WriteLine("Nhap thong tin: ");
             Inputmaker:
                Console.Write("Input maker: "); 
                maker = Console.ReadLine();
                if (string.IsNullOrEmpty(maker))
                    goto Inputmaker;
            Inputmodel:
                Console.Write("Input model: ");
                model = Console.ReadLine();
                if (string.IsNullOrEmpty(model))
                    goto Inputmodel;
             Console.Write("Input price: ");
             price = double.Parse(Console.ReadLine());
             

        }
        public virtual void display()
        {
            Console.Write("{0} ;{1} ;{2} vnd", maker, model, price);
        }
    }
}
