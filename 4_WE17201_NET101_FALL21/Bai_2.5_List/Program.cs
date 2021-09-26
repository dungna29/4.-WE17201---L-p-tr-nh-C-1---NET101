using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2._5_List
{
    class Program
    { /*
         *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
         *
         *  1.Khai báo:
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
         */
        /*
       * A. CÁC PHƯƠNG THỨC TRONG List
       * 1. Add(object Value): Thêm đối tượng vào cuối.
       * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
       * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
       * 4. Clear(): Xóa tất cả các phần tử.
       * 5. Clone(): Tạo 1 bản sao của danh sách đó.
       * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
       * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
       * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
       *9.CopyTo(<tên mảng>,<index>): Thực hiện sao chép các phần tử List về mảng 1 chiều từ index của mảng
       * 10. Remove(<value>): Xóa value ở trong List
       *
       * Ngoài ra còn có thêm 1 số phương thức khác
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo và khởi tạo
            List<int> lstYears;//Khai báo 1 lst year
            lstYears = new List<int>();//Khởi tạo thì mới sử dụng
            List<double> lstDiemCsharp = new List<double>();
            List<string> lstNames = new List<string>();
            //.... CÒn rất nhiều kiểu dữ liệu khác.

            //PHần 2: Gán giá trị cho nó 
            lstYears.Add(2021);
            lstYears.Add(2022);
            lstYears.Add(2023);
            

            //Phần 3: Truy xuất cũng cần có index
            Console.WriteLine(lstYears[0]);
            for (int i = 0; i < lstYears.Count; i++)
            {
                Console.WriteLine(lstYears[i]);
            }

            foreach (var x in lstYears)
            {
                Console.WriteLine(x);
            }
            //Phần 4: Một vài phương thức
            lstYears.RemoveAt(0);
            foreach (var x in lstYears)
            {
                Console.WriteLine(x);
            }
            //Khám phá thêm các phương thức khấc
            lstYears.Clear();
        }
    }
}
