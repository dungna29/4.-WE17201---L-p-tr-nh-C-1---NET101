using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua
{
    //Lớp cha bản chất vẫn là 1 lớp đối tượng
    class Nguoi
    {
        //Đưa các thuộc tính chung lên cho lớp cha
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

        public virtual void inRaManHinh()
        {
            Console.WriteLine("Đây là inRaManHinh lớp cha");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
