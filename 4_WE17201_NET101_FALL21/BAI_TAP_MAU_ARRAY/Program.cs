using System;
using System.Text;

namespace BAI_TAP_MAU_ARRAY
{
    class Program
    {   /*
        Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
        
        Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điểm thông báo Trượt hoặc đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int[] arrNumber;
            int size;
            Console.WriteLine("Bạn muốn thêm bao nhiêu số: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrNumber = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Mời bạn nhập số tại Index {0}:",i);
                arrNumber[i]= Convert.ToInt32(Console.ReadLine());
            }

            //Hiển thị ra dòng Chẵn lẻ?
            Console.Write("Các số chẵn: ");
            for (int i = 0; i < size; i++)
            {
                if (arrNumber[i] %2 == 0)
                {
                    Console.Write(arrNumber[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Các số lẻ: ");
            for (int i = 0; i < size; i++)
            {
                if (arrNumber[i] % 2 != 0)
                {
                    Console.Write(arrNumber[i] + " ");
                }
            }
        }
    }
}
