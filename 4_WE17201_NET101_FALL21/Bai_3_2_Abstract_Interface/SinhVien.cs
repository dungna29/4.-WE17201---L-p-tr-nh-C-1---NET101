using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    //Khi kế thừa lớp cha là 1 abstract thì bắt buộc phải ghi đè lại tất cả các phương thức abstract
    class SinhVien :Nguoi
    {
        private string msv;

        public SinhVien()
        {
            
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        
        public override void inRaManHinh2()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh3()
        {
            throw new NotImplementedException();
        }
    }
}
