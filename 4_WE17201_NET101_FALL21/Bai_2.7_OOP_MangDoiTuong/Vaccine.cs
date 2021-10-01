using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._7_OOP_MangDoiTuong
{
    class Vaccine
    {
        private string tenVaccine;
        private string nsx;
        private int thoiGianTacDung;

        public Vaccine()
        {
            
        }

        public Vaccine(string tenVaccine, string nsx, int thoiGianTacDung)
        {
            this.tenVaccine = tenVaccine;
            this.nsx = nsx;
            this.thoiGianTacDung = thoiGianTacDung;
        }

        public string TenVaccine
        {
            get => tenVaccine;
            set => tenVaccine = value;
        }

        public string Nsx
        {
            get => nsx;
            set => nsx = value;
        }

        public int ThoiGianTacDung
        {
            get => thoiGianTacDung;
            set => thoiGianTacDung = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine($"Tên: {TenVaccine} | Nsx: {Nsx} | Thời gian tác dụng: {ThoiGianTacDung}");
        }

    }
}
