using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Test
    {
        Car[] car;
        Truck[] truck;
        public void input()
        {
            car = new Car[3];
            truck = new Truck[3];
            for (int i = 0; i < 3; i++)
            {
                car[i] = new Car();
                car[i].input();
            }
            for (int i = 0; i < 3; i++)
            {
                truck[i] = new Truck();
                truck[i].input();
            }
        }
        public void display()
        {
            Console.WriteLine("\tCar is: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t{0}: ", i + 1);
                car[i].display();
            }
            Console.WriteLine("\tTruck is: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t{0}: ", i + 1);
                truck[i].display();

            }
        }

        public void sort()
        {
            var sortCar = from c in car
                          orderby c.Price ascending
                          select c;
            var sortTruck = from tr in truck
                            orderby tr.Price ascending
                            select tr;

            //var sortCaTr =from c in car
            //              from tr in truck
            //              orderby c.Price, tr.Price 
            //              select new{ c, tr };

            int i = 1, k = 1;
            Console.WriteLine("\tCar: ");
            foreach (var value in sortCar)
            {
                Console.Write("\t\t{0}: ", i);
                value.display();
                i++;
            }
            Console.WriteLine("\tTruck: ");
            foreach (var value in sortTruck)
            {
                Console.Write("\t\t{0}: ", k);
                value.display();
                k++;
            }
        }

        public void search()
        {
            Console.Write("Nhap key model search: ");
            string key = Console.ReadLine();
            var answer1 = from c in car
                          where c.Model == key
                          select c;
            var answer2 = from tr in truck
                          where tr.Model == key
                          select tr;
            int i = 1, k = 1;
            if (answer1 != null && answer1.Count() > 0)
            {
                Console.WriteLine("\tCar: ");
                foreach (var value in answer1)
                {
                    Console.Write("\t\t{0}: ", i);
                    value.display();
                    i++;
                }
            }
            if (answer2 != null && answer2.Count() > 0)
            {
                Console.WriteLine("\tTruck: ");
                foreach (var value in answer2)
                {
                    Console.Write("\t\t{0}: ", k);
                    value.display();
                    k++;
                }
            }
            if (answer1 == null && answer2 == null)
                Console.WriteLine("\tKhong co ket qua tra");
        }

        public void menu()
        {
            int i = 1;
            Test a = new Test();
            while (0 < i && i < 6)
            {
                Nhapchiso:
                {
                    Console.Write("Nhap chi so chon: ");
                    i = Int32.Parse(Console.ReadLine());
                }
                //chọn 1, nhập thông tin vào cho mảng 3 đối tượng Car và mảng 3 đối tượng Truck.
                if (i == 1)
                    a.input();
            
                //chọn 2, hiển thị toàn bộ thông tin của 3 Car và 3 Truck
                if (i == 2)
                {
                    if (a.car == null && a.truck==null)
                        goto Nhapchiso;
                        
                    Console.WriteLine("Danh sach xe: ");
                    a.display();
                    
                }
                //chọn 3, hiển thị danh sách các xe trước khi sắp xếp và sau khi sắp xếp theo giá.
                if (i == 3)
                {
                    if (a.car == null && a.truck == null)
                        goto Nhapchiso;
                    Console.WriteLine("Danh sach xe sau khi sap xep tang dan theo price: ");
                    a.sort();
                }
                //chọn 4, người dùng sẽ phải nhập vào 1 chuỗi, sau đó chương trình in ra 
                //dối tượng có model đó.
                if (i == 4)
                {
                    if (a.car == null && a.truck == null)
                        goto Nhapchiso;
                    Console.WriteLine("\tDanh sach tim kiem: ");
                    a.search();
                }
                //Khi chọn 5, kết thúc chương trình. Thoát và trở về HDH.
                if (i == 5)
                {
                    Console.WriteLine("\n\tThoat chuong trinh !!!");
                    break;
                }
            }

        }
    }
}
