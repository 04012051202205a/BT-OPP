using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Acount
    {
        private string ID;
        private string Name;
        private int Balance;
        public Acount(string ID, string Name, int balance)
        {
            this.ID = ID;
            this.Name = Name;
            this.Balance = balance;
        }
        public string getID()
        {
            return ID;
        }
        public string getName()
        {
            return Name;

        }
        public int getBalance()
        {
            return Balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("so tien khong hop le");

        }
        public void debit(int amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("so tien k du,rut tien khong thanh cong");
        }
        public void tranfer(Acount acc,int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                acc.Balance -= amount;
            }
            else
                Console.WriteLine("so tien vuot qua so du");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            Acount my = new Acount("999999", "Tran Van B", 200000000);
            Console.Write("ID cua tai khoan ");
            string ID = Console.ReadLine();
            Console.Write("Ten tai khoan ");
            string Name = Console.ReadLine();
            Console.Write("so tien co trong tai khoan ");
            int balance = int.Parse(Console.ReadLine());
            Acount myfriend = new Acount(ID, Name, balance);
            Console.Write("chuyen tien ");
            amount = int.Parse(Console.ReadLine());
            Console.Write("so tien muon rut la ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------Thong tin 2 tai khoan --------------");
            Console.WriteLine("ID:{0},Name:{1},so du:{2}", my.getID()
               , my.getName(), my.getBalance());
            Console.WriteLine("ID:{0},Name:{1},so du:{2}", myfriend.getID()
                , myfriend.getName(), myfriend.getBalance());
            Console.ReadLine();
            
           
            
            
        }
    }
}
