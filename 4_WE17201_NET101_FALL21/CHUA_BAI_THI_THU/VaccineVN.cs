using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUA_BAI_THI_THU
{
    class VaccineVN:Vaccine
    {
        private string quocGia;

        public VaccineVN()
        {
            
        }

        public VaccineVN(string maVc, string tenVc, float thoiGianTacDung, string ngayHetHan, string quocGia) : base(maVc, tenVc, thoiGianTacDung, ngayHetHan)
        {
            this.quocGia = quocGia;
        }

        public string QuocGia
        {
            get => quocGia;
            set => quocGia = value;
        }

        public override void InRaManHinh()
        {
            Console.WriteLine(quocGia);
            base.InRaManHinh();
        }
    }
}
