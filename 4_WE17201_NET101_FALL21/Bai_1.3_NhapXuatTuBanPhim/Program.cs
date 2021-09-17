using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3_NhapXuatTuBanPhim
{
    class Program
    {
        /*
         * BÀI 1.23 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Xuất dữ liệu ra màn hình
            Console.Write("Chào các bạn ");
            Console.WriteLine("học môn C#");
            Console.Write(" tại \n FPOLY \n");
            //Ctrl + F5 chạy chương trình

            //Tạo template mẫu
            Console.WriteLine("Chào bạn: {0} Năm Sinh: {1} Trường: {2}","Hương",2000, "Fpoly");

            Console.WriteLine("Chào bạn: Hương Năm Sinh: 2000 Trường: Fpoly");

            //Phần 2: Nhập dữ liệu từ bàn phím
            //Ví dụ: Viết 1 chương trình nhập tên và in ra màn hình

            //Bước 1: Xác định số lượng biến cần sử dụng và kiểu dữ liệu
            string name;

            //Bước 2: Chỉ dẫn cho người dùng cần phải làm gì
            Console.Write("Mời bạn nhập tên: ");

            //Bước 3: Gán giá trị do người dùng nhập vào Console.ReadLine() có kiểu dữ liệu là string
            name = Console.ReadLine();
          
            //Bước 4: Thực thi
            Console.WriteLine("Chào bạn " + name);//Hành động cuối in ra màn hình



            //Console.Read() - Có kiểu số nguyên
            int temp;
            Console.WriteLine("Mời bạn nhập 1 ký tự: ");
            temp = Console.Read();
            Console.WriteLine("Giá trị Console.Read() = " + temp);
            /*
             * Mã ASII
             * a = 97
             * A = 65
             */
            
        }
    }
}
