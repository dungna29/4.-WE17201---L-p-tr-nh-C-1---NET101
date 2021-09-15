using System;

namespace BAI_1._2_BienLaGi
{
    class Program
    {
        /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến
         * được khở tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         *  CÔNG THỨC: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         *
         *  1. <Kiểu dữ liệu>: Giúp định nghĩa kiểu dữ liệu cho biến cần lưu trữ giá trị gì.
                        + Số nguyên:sbyte, byte, long, int
                        + Sô thực: float, double, decimal
                        + Chuỗi hoặc ký tự: string, char
                        + Logic: bool
                        + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         *
         *  2. <Tên Biến>: Định danh biến giúp phân biệt giữa các biến trong 1 file.     Lam
         *      + Quy tắc đặt tên:
         *          - Tên biến phải có nghĩa
         *          - Biến có phân biệt chữ hoa chữ thường
         *          - Không bắt đầu bởi số, không dùng từ khóa
         *          - Cố gắng làm quen đặt tên biến với Tiếng Anh.
               + Khai báo tên biến với 2 từ trở lên:
                 - Cách 1: normal = firstname
                 - Cách 2: CamelCase = FirstName, firstName
                 - Cách 3: Under_Score = first_name, first_Name

         *     + Biến cục bộ: là 1 biến được khai báo bên trong 1 phương thức. Không thể gọi biến cục bộ sang 1 phương thức khác.
         *     + Biến toàn cục: là 1 biến được khai báo bên ngoài phương thức . Các phương thức có thể gọi đến nó.
         *              - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến. Biến toàn cục luôn đặt ở trên đầu của Class.
         *              - Ví dụ: int _year = 1989;
         *
         * 3. <Giá trị>:
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng với quy tắc của kiểu dữ liệu;
         */

        private int _year;
        static void Main(string[] args)
        {
          //1. Chuỗi
          string name1;//Khởi tạo 1 biến tên name1 có kiểu dữ liệu là string và không khởi tạo giá trị ban đầu.
          string name2 = "FPOLY";//Khởi tạo 1 biến tên name2 có kiểu dữ liệu là string và có khởi tạo giá trị ban đầu.
          string name3, name4, name5 = "C#1";//Khai báo nhiều biến trên cùng một dòng miễn có cùng kiểu dữ liệu.

          //2. Logic
          bool logic1 = true;
          bool logic2 = false;

          //3. var - Kiểu dữ liệu ngầm định
          //var v0;//Phải khởi tạo giá trị ngay khi sử dụng
          var v1 = 1;//int
          var v2 = "1";//string
          var v3 = '1';//char
          var v4 = 5.6;//double
          var v5 = true;//bool
        }
    }
}
