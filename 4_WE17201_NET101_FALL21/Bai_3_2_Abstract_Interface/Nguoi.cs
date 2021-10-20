using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
   abstract class Nguoi//abstract lớp trừu tượng
    {
        private string ten;
        private string sdt;
        private int ns;
        private string cmt;
        private string queQuan;

        public Nguoi()
        {
            
        }

        public Nguoi(string ten, string sdt, int ns, string cmt, string queQuan)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.ns = ns;
            this.cmt = cmt;
            this.queQuan = queQuan;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public string Cmt
        {
            get => cmt;
            set => cmt = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public virtual void inRaManHinh1()
        {

        }

        public abstract void inRaManHinh2();//1 Phương thức abstract sẽ không body code
        public abstract void inRaManHinh3();
    }
}
