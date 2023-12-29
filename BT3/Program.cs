using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;
        public void Phanso()
        {
            TuSo = 1;
            MauSo = 4;
        }
        public void Phanso(int tuso,int mauso)
        {
            this.TuSo = tuso;
            this.MauSo = mauso;
        }
        public void setTuSo(int tuso)
        {
            this.TuSo = tuso;
        }
        public int getTuSo()
        {
            return TuSo;
        }
        public void setMauSo()
        {
            this.MauSo = MauSo;
        }
        public int getMauSo()
        {
            return MauSo;
        }
        public void ToiGian()
        {
            int uscln = TimUSCLN(TuSo, MauSo);
            TuSo = TuSo / uscln;
            MauSo = MauSo / uscln;
        }
        private int TimUSCLN(int a,int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while(x!=y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo + ps.TuSo * MauSo;
            kq.MauSo = MauSo * ps.MauSo;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo + ps.TuSo * MauSo;
            kq.MauSo = MauSo * ps.MauSo;
            return kq;
        }
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.TuSo;
            kq.MauSo = MauSo * ps.TuSo;
            return kq;
        }
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = TuSo * ps.MauSo;
            kq.MauSo = TuSo * ps.MauSo;
            return kq;
        }

        
    }


   
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
