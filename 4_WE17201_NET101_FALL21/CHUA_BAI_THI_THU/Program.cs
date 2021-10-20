using System;
using System.Text;

namespace CHUA_BAI_THI_THU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLVC ql = new QLVC();
            string input;
            do
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Xuất ds");
                Console.WriteLine("3. Xuất có ĐK");
                Console.WriteLine("4. Sắp Xếp");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ql.add();
                        break;
                    case "2":
                        ql.inDs();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("Hẹn gặp lại lần sau");
                       return;
                    default:
                        Console.WriteLine("CN không tồn tại");
                        break;
                }
            } while (true);
        }
    }
}
