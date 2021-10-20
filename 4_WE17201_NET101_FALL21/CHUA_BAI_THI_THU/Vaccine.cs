using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUA_BAI_THI_THU
{
    class Vaccine
    {
        private string maVC;
        private string tenVC;
        private float thoiGianTacDung;
        private string ngayHetHan;

        public Vaccine()
        {
            
        }

        public Vaccine(string maVc, string tenVc, float thoiGianTacDung, string ngayHetHan)
        {
            maVC = maVc;
            tenVC = tenVc;
            this.thoiGianTacDung = thoiGianTacDung;
            this.ngayHetHan = ngayHetHan;
        }

        public string MaVc
        {
            get => maVC;
            set => maVC = value;
        }

        public string TenVc
        {
            get => tenVC;
            set => tenVC = value;
        }

        public float ThoiGianTacDung
        {
            get => thoiGianTacDung;
            set => thoiGianTacDung = value;
        }

        public string NgayHetHan
        {
            get => ngayHetHan;
            set => ngayHetHan = value;
        }

        public virtual void InRaManHinh()
        {
            Console.WriteLine($"{maVC} {tenVC} {thoiGianTacDung} {ngayHetHan}");
        }
    }
}
