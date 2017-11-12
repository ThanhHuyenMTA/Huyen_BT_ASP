using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11_Book
{
    class Book
    {
        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private string id_book;

        public string Id_book
        {
            get { return id_book; }
            set { id_book = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Book() { }
        public Book(string isbn, string title, string id)
        {
            this.isbn = isbn;
            this.title = title;
            this.id_book = id;
        }
        public void Input()
        {
            Console.Write("Nhap ma ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Nhap ma Title: ");
            title = Console.ReadLine();
            Console.Write("Nhap ma id_Book: ");
            id_book = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("\tName: {0} _ MaISBN: {1} _ MaSach: {2}",title,isbn,id_book);
        }
    }
}
