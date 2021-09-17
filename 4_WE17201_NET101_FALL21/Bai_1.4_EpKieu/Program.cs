using System;
using System.Text;
using System.Threading.Channels;

namespace Bai_1._4_EpKieu
{
    class Program
    {
        #region Ép kiểu trong lập trình
        /*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Ví dụ 1: Cộng chuỗi
            // string ho, tendem, ten;
            // Console.WriteLine("Mời bạn nhập Họ: ");
            // ho = Console.ReadLine();
            // Console.WriteLine("Mời bạn nhập Tên Đệm: ");
            // tendem = Console.ReadLine();
            // Console.WriteLine("Mời bạn nhập Tên: ");
            // ten = Console.ReadLine();
            // Console.WriteLine("Chào bạn: {0} {1} {2}",ho,tendem,ten);

            //Phần 1: Ép kiểu giá trị khi nhập vào từ string về số
            //Ví dụ 2: Cộng 2 số a và b
            int a, b, c;
            Console.WriteLine("Mời bạn nhập số thứ a: ");
            a = int.Parse(Console.ReadLine());//Ép kiểu từ string về int
            Console.WriteLine("Mời bạn nhập số thứ b: ");
            b = Convert.ToInt32(Console.ReadLine());//Ép kiểu từ string về int
            c = a + b;
            Console.WriteLine("{0} + {1} = {2}",a,b,c);

            //Phần 2: Chuyển dổi kiểu dữ liệu số
            int temp1 = 5;
            double temp2 = 6.5;
            //temp2 = temp1;//Gán giá trị từ int về double
            //temp1 = temp2; Không thể gán giá trị từ kiểu dữ liệu có size lớn về kiểu dữ liệu có size bé
            temp1 = (int)temp2;//Ép kiểu và loại bỏ thập phân
            Console.WriteLine(temp1);
            /*
             Bài 1: Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên từ bàn phím và xuất ra định dạng sau: 
             “Chào bạn <<họ và tên>> | <<Tuổi>> |<<năm sinh>>  | <<mã sinh viên>> 
             đến với chương trình Csharp1 đầu tiên.”

              Bài 2: Nhập 3 đầu điểm Địa, Toán, Văn sau đó tính điểm trung bình của 3 đầu điểm đó.
             */
        }
    }
}
