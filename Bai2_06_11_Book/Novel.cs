using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11_Book
{
    class Novel
    {
        private int length;
        Book[] listbook;
        public Novel(int length)
        {
            this.length= length;
            Console.Write("Nhap do dai cua mang: ");
            length =Int32.Parse(Console.ReadLine());
            listbook = new Book[length];
        }
       
        public Book this[int indexer]
        {
            get
            {
                if (indexer < 0 || indexer > listbook.Length)
                {
                    return null;
                }
                else
                    return listbook[indexer];
            }
            set
            {
                if (indexer > 0 && indexer < listbook.Length)
                {
                    listbook[indexer] = value;
                }
                    
            }
        }
        public void Input()
        {
            Console.WriteLine("Nhap danh sach books: ");
            for(int i=0;i<listbook.Length;i++)
            {
                Console.WriteLine("Nhap sach thu {0}:", i + 1);
                Console.Write("Nhap ma ISBN: "); listbook[i].Isbn = Console.ReadLine();
                Console.Write("Nhap ma Title: "); listbook[i].Title = Console.ReadLine();
                Console.Write("Nhap ma id_Book: "); listbook[i].Id_book = Console.ReadLine();
            }
        }

        public void Display()
        {
            foreach(var value in listbook)
            {
                Console.WriteLine("\tName: {0} _ MaISBN: {1} _ MaSach: {2}", value.Title, value.Isbn, value.Id_book);
            }
            
        }
    }
}
