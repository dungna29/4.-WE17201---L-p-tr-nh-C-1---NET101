using System;
using System.Text;

namespace Bai_2._0_CauLenh_Switch_Case
{
    class Program
    {
        /*
        * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
        *
        * Công thức: sw + tab
        *
        *  switch (<Biểu thức>)
           {
               case <giá trị 1>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break; 
               case <giá trị 2>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               .......
               case <giá trị n>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               default:
                   Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                   break;
           }
        */
        static void Main(string[] args)
        {
            char choice;
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("Chọn Vacxin Covid tiêm");
            Console.WriteLine("1. Vacxin Việt Nam");
            Console.WriteLine("2. Vacxin Cuba");
            Console.WriteLine("3. Vacxin Nga");
            Console.WriteLine("Mời bạn chọn vacxin để tiêm: ");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Bạn ra Bộ y tế đăng ký nhé");
                    break; 
                case '2':
                    Console.WriteLine("Vacxin Cuba còn rất ít ko đủ để cho bạn đăng ký tiêm");
                    break;
                case '3':
                    Console.WriteLine("Đã hết hàng");
                    break;
                default:
                    Console.WriteLine("Chúng tôi không cung cấp vacxin bạn cần");
                    break;
            }
        }
    }
}
