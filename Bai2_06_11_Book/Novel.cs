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
        Book[] listbook =new Book[3];
        public Novel(int length)
        {
            this.length= length;
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
            for (int i = 0; i < listbook.Length; i++)
            {
                Console.WriteLine("Nhap sach thu {0}:", i + 1);
                listbook[i] = new Book();
                listbook[i].Input();
            }
        }

        public void Display()
        {
            for (int i = 0; i < listbook.Length; i++)
            {
                listbook[i].Display();
            }
        }
    }
}
