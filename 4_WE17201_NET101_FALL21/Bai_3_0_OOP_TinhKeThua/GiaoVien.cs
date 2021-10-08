using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua
{
    class GiaoVien:Nguoi
    {
        private string mgv;
        private double gioDay;

        public GiaoVien()
        {
            
        }

        public GiaoVien(string ten, string sdt, int ns, string cmt, string queQuan, string mgv, double gioDay) : base(ten, sdt, ns, cmt, queQuan)
        {
            this.mgv = mgv;
            this.gioDay = gioDay;
        }

        public string Mgv
        {
            get => mgv;
            set => mgv = value;
        }

        public double GioDay
        {
            get => gioDay;
            set => gioDay = value;
        }

        public override void inRaManHinh()
        {
            Console.WriteLine("Đây là inRaManHinh() giao Vien");
        }
    }
}
