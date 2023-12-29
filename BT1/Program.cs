using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Rectangle
    {
        private double chieudai;
        private double chieurong;
        public Rectangle()
        {
            chieudai = 1.0;
            chieurong = 2.0;

        }
        public Rectangle(double chieudai,double chieurong)
        {
            this.chieudai = chieudai;
            this.chieurong = chieurong;
        }
        public void setchieudai(double chieudai)
        {
            this.chieudai = chieudai;
        }
        public double getchieudai()
        {
            return chieudai;
        }
        public void setchieurong(double chieurong)
        {
            this.chieurong = chieurong;
        }
        public double getchieurong()
        {
            return chieurong;
        }
        public double dientich()
        {
            return chieudai * chieurong;
        }
        public double chuvi()
        {
            return (chieurong + chieudai) *2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            Rectangle r2;
            r1 = new Rectangle();
            r2 = new Rectangle();
            Console.Write(" Chieu dai hinh chu nhat = ");
            double chieudai = double.Parse(Console.ReadLine());
            Console.Write("Chieu rong hinh chu nhat = ");
            double chieurong = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------ket qua phep tinh la----------------");
            Console.WriteLine("----------HINH CHU NHAT THU 1------------");
            Console.WriteLine(" chieu dai {0}\n chieurong {1}\n dientich {2}\n chuvi {3}\n", r1.getchieudai(), r1.getchieurong(), r1.dientich(), r1.chuvi());
            Console.WriteLine("----------HINH CHU NHAT THU 2------------");
            Console.WriteLine(" chieu dai {0}\n chieurong {1}\n dientich {2}\n chuvi {3}\n", r2.getchieudai(), r2.getchieurong(), r2.dientich(), r2.chuvi());
            Console.ReadLine();
        }
    }
}
