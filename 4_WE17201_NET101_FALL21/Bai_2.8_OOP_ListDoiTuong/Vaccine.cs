using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._8_OOP_ListDoiTuong
{
    class Vaccine
    {
        private string maVaccine;
        private string tenVaccine;
        private string nsx;
        private int thoiGianTacDung;

        public Vaccine()
        {
            
        }

        public Vaccine(string maVaccine, string tenVaccine, string nsx, int thoiGianTacDung)
        {
            this.maVaccine = maVaccine;
            this.tenVaccine = tenVaccine;
            this.nsx = nsx;
            this.thoiGianTacDung = thoiGianTacDung;
        }

        public string MaVaccine
        {
            get => maVaccine;
            set => maVaccine = value;
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
            Console.WriteLine($"{MaVaccine} | {tenVaccine} | {Nsx} | {ThoiGianTacDung}");
        }
    }
}
