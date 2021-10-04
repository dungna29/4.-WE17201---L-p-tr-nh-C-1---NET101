using System;
using System.Text;

namespace Bai_2._8_OOP_ListDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Gọi lớp chứa các chức năng lên main
            VaccineSerrvice serrvice = new VaccineSerrvice();
            string input;
            while (true)
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Xuat ds");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        serrvice.addVaccine();
                        break;
                    case "2":
                        serrvice.suaVaccine();
                        break;
                    case "3":
                        serrvice.xoaVaccine();
                        break;
                    case "4":
                        serrvice.TimKiemNangCaoLstVaccine();
                        break;
                    case "5":
                        serrvice.getLstVaccine();
                        break;
                }
            }
        }
    }
}
