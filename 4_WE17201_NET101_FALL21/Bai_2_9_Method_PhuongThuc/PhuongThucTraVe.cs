using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_9_Method_PhuongThuc
{
    class PhuongThucTraVe
    {
        /*
          *  Phương thức trả về là :
          *   Công thức chung:
          *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
          *  {
          *          Body code
          *          return <Kiểu trả về của phương thức>
          *  }
          */

        //Phương thức trả về không tham số
        /*
         * Hướng dẫn sử dụng:
         *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu...
         *      2. Phải Sử dụng return <giá trị hoặc tập giá trị> đúng với kiểu dữ liệu
         */

       
        // public void tinhTong()//() không tham số
        // {
        //     int a, b;
        //     Console.WriteLine("Mời bạn nhập sô a:");
        //     a = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Mời bạn nhập sô b:");
        //     b = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine($"Tổng của a + b = {a + b}");
        // }

        //Phần 1: Phương thức trả về không tham số
        public int tinhTong()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập sô a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập sô b:");
            b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }

        public int[] getAllYears()
        {
            int[] arr = new int[2022 - 1900];
            int temp = 1900;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp;
                temp++;
            }
            return arr;
        }

        public SinhVien getSinhVien()
        {
            return new SinhVien();
        }
    }
}
