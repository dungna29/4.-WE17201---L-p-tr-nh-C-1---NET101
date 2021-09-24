using System;
using System.Text;

namespace Bai_2._1_VongLap
{
    class Program
    {
        #region Định nghĩa Vòng Lặp

        #region 1. Vòng lặp for
        /*
        * Vòng lặp for
        *
        * Cách gõ: for + tab
        * Công thức:
        *  for (int i = 0; i < UPPER; i++)
           {
               //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
           }
           int i = 0: Điểm bắt đầu của vòng lặp
           i < UPPER: Điều kiện để ngắt vòng lặp
           i++: Tăng i lên 1
        */


        #endregion

        #region 2. While
        /*
         * Bài 2.0 Vòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }
         */


        #endregion

        #region 3. Vòng lặp do..While

        /*
          * Bài 2.1 Vòng lặp do..While khác với vòng lặp while đó là sẽ thực hiện hành động 1 lần kể cả khi while(False). Điều kiện kiện để chạy vòng lặp vẫn là While(true)
          *
          * Cách gõ: do + tab
          *
          * Công thức:
          *  do
             {
                 //Thực hiện ít nhất 1 lần nếu While False             
             } while (false);
          */

        #endregion
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Công thức chung dùng vòng lặp:
             * 1 . Điều kiện để vòng lặp chạy là điều kiện luôn đúng
             * 2 . Điểm bắt đầu chạy của vòng lặp hoặc là khởi tạo điểm bắt đầu.
             * 3 . Bước nhẩy để giúp đạt điều kiện dừng vòng lặp.
             * Continue: Bỏ qua đoạn code phía sau nó và tiến hành chạy lại vòng mới
             * Break: Ngắt vòng lặp
             */
            //for + tab
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Chào các bạn");
            // } 

            //while: wh + tab
            // int i = 0;
            // while (i < 3)
            // {
            //     Console.WriteLine("Chào các bạn");
            //     i++;
            // }

            //do...while: do + tab
            // int i = 0;
            // do
            // {
            //     Console.WriteLine("Chào các bạn");
            //     i++;
            // } while (i < 3);

            /*
         * Vòng lặp foreach
         * Cách gõ: fore + tab
         *
         * Công thức:
         *  foreach (var VARIABLE in COLLECTION)
            {
                
            }
            var: Kiểu dữ liệu đã học ở bài khai báo biến
            VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
            COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
         */
            string[] arrName = {"UDPM", "WEB", "MOB"};
            foreach (var x in arrName)
            {
                Console.WriteLine(x);
            }
        }
    }
}
