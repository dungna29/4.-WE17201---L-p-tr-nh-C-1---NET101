using System;
using System.Text;

namespace Bai_3_0_OOP_TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Nguoi nguoi1 = new Nguoi("Dũng", "0123", 2000, "012000", "HN");
            nguoi1.inRaManHinh();
            Console.WriteLine(nguoi1);

            SinhVien sv1 = new SinhVien("Dũng", "0123", 2000, "012000", "HN", "PH000", 9.2);
            sv1.inRaManHinh();

            GiaoVien gv1 = new GiaoVien("Dũng", "0123", 2000, "012000", "HN", "DUNGNA29", 60.5);
        }
    }
}
