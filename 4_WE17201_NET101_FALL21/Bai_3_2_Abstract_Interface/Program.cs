using System;

namespace Bai_3_2_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ISinhVienService iSinhVienService = new SinhVienService();
            iSinhVienService.sua();
            
        }
    }
}
