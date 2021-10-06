using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_9_Method_PhuongThuc
{
    class Void_PhuongThucKhongTraVe
    {
        /*
     *  Phương thức không trả về là : Void
     *   Công thức chung:
         <Tên phương thức>: Viết thường ở từng đầu tiên và nó phải động từ
     *  <Phạm vi truy cập> <Kiểu phương thức> <Tên phương thức> (<Danh sách tham số>)
     *  {
     *          Body code
     *  }
     */
        //Phần 1: Phương thức không trả về không tham số
        public void tinhTong()//() không tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập sô a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập sô b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tổng của a + b = {a+b}");
        }
        //Tên phương thức không thể trùng nhau
        // public void tinhTong()//() không tham số
        // {
        //     int a, b;
        //     Console.WriteLine("Mời bạn nhập sô a:");
        //     a = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Mời bạn nhập sô b:");
        //     b = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine($"Tổng của a + b = {a + b}");
        // }

        //Phần 2: Phương thức không trả về có tham số
        public void tinhTongCacSo(int a, int b)//(int a, int b) là 2 tham số
        {
            Console.WriteLine($"Tổng của a + b = {a + b}");
        }
        //Nạp chồng phương thức trong tính đa hình
        public void tinhTongCacSo(int a, int b,int c)
        {
            Console.WriteLine($"Tổng của a + b + c= {a + b + c}");
        }
        public void tinhTongCacSo(int a, int b, int c, int d)
        {
            // Console.WriteLine($"Tổng của a + b + c + d= {a + b + c + d}");
            Console.WriteLine("Chịu không tính đc");
        }

        //Tham số không nhất thiết phải có cùng kiểu dữ liệu
        public void method1(int[] arr,long a, SinhVien sv,List<string> lst,List<SinhVien> lstsv)
        {
            for (int i = 0; i < lstsv.Count; i++)
            {
                
            }
        }
    }
}
