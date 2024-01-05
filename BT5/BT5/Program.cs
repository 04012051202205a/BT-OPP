using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class CD
    {
        private int Macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int dongia;
        public CD()
        {

        }
        public CD(int madc)
        {
            this.MaCD = madc;
        }
        public CD(int macd,string tuaCD,string casi,int sobaihat,int giathanh)
        {
            this.MaCD = macd;
            this.TuaCD = tuaCD;
            this.CaSi = casi;
            this.SoBaiHat = sobaihat;
            this.dongia = giathanh;
        }
        public int MaCD
        {
            set { this.Macd = value; }
            get { return Macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }

        }
        public string CaSi
        {
            set { this.casi = value; }
            get { return casi; }

        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }

        }
        public int  DonGia
        {
            set { this.dongia = value;}
            get { return dongia; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4,15:#,##0}", MaCD, tuacd, casi, sobaihat,dongia);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanlyCD = new QuanLyCD();
            int chon = 6;
            do
            {
                Console.WriteLine("********************CHUONG TRINH QUAN LU CD*************************");
                Console.WriteLine("1) Them CD");
                Console.WriteLine("2) Tinh gia thanh trung binh");
                Console.WriteLine("3) Sap sep CD giam dan theo gia thanh");
                Console.WriteLine("4) Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5) Xuat toan bo CD");
                Console.WriteLine("6) Thoat chuong trinh");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.Write("Bam Chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD ");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD ");
                        cd.TuaCD = (Console.ReadLine());
                        Console.Write("Nhap ca si ");
                        cd.CaSi = (Console.ReadLine());
                        Console.Write("Nhap so bai hat ");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh ");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanlyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanlyCD.TinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh : {0:#,##0.00", kq);
                        break;
                    case 3:
                        quanlyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap sep theo gia thanh giam dan ");
                        break;
                    case 4:
                        break;
                    case 5:
                        quanlyCD.Xuat();
                        break;
                    case 6:
                        Console.WriteLine("Tam biet hen gap lai ");
                        Console.ReadLine();
                        break;
                }


            } while (chon != 6);  
        }
    }
}
