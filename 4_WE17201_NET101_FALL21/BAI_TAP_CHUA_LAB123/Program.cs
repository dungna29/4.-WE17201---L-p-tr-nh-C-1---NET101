using System;
using System.Text;

namespace BAI_TAP_CHUA_LAB123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 2 khoảng bảng cửu chương
            int a, b;
            Console.WriteLine("Mời bạn nhập vào khoảng bắt đầu: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào khoảng kết thúc: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Cách 1: Sử dụng thuật toán hoán vị ở trong thuật toán nổi bọt.
            // if (a>b)
            // {
            //     int temp = a;
            //     a = b;
            //     b = temp;
            // }
            for (int i = Math.Min(a,b); i <= Math.Max(a, b); i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",i,j,i*j);
                }
            }
        }
    }
}
