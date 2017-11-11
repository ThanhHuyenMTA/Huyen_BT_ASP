using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNhanSu
{
    class NhanVien
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public NhanVien()
        {

        }
        public NhanVien(string name, string address, DateTime birthday)
        {
            this.name = name;
            this.address = address;
            this.birthday = birthday;
        }

        public virtual void Input()
        {
            Inputname:
                Console.Write("Input name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    goto Inputname;

            InputAddress:
                Console.Write("Input address: ");
                address = Console.ReadLine();
                if (string.IsNullOrEmpty(address))
                    goto InputAddress;

            InputBirthday:
                Console.Write("Input birthday: ");
                DateTime _birthday = DateTime.Now;
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out _birthday))
                    birthday = _birthday;
                else
                    goto InputBirthday;

        }
        public virtual void Output()
        {
            Console.Write("{0}; {1}; {2}", name, address,String.Format("{0:MM/dd/yyyy}",birthday));
        }
        public virtual float Tienluong()
        {
            float tienluong =0;
            return tienluong;
        }

    }
}
