using System;

namespace Bai_2._1_Array
{
    class Program
    {
        /*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Loại Biến dùng để lưu trữ 1 giá trị đơn có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán;
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            //Phần 1: Khai báo biến
            //<Kiểu dữ liệu> <Tên biến> = <Giá trị>;
            int a = 5;
            a = 10;

            //Phần 2: Khai báo 1 mảng phải đặt tên arr
            int[] arrNubmer1;//Khai báo 1 mảng
            arrNubmer1 = new int[5];//Khởi tạo 1 mảng int có kích thước là 5

            string[] arrNames = new string[5];
            int[] arrYears = {2001, 2002, 2003};//Khởi tạo 1 mảng có 3 phần tử
            int[] arrYears1 = new int[]{2001, 2002, 2003,0,0};//Cách viết tường minh hơn

            var arrNames1 = new string[5];

            //Phần 3: Gán giá trị trong mảng cần phải biết index
            //arrNubmer1 = 5;
            arrNubmer1[0] = 5;//Gán giá trị cho mảng tại index 0
            arrNubmer1[1] = 11;
            arrNubmer1[2] = 12;

            //Phần 4: Truy xuất giá trị trong mảng cần phải biết index
            Console.WriteLine(arrNubmer1[0]);
            Console.WriteLine(arrNubmer1[1]);
            Console.WriteLine(arrNubmer1[2]);
            Console.WriteLine(arrNubmer1[3]);
            Console.WriteLine(arrNubmer1[4]);
            //Console.WriteLine(arrNubmer1[5]); IndexOutOfRangeException

            //For
            for (int i = 0; i < arrNubmer1.Length; i++)//arrNubmer1.Length = kích thước mảng có kiểu số nguyên
            {
                Console.WriteLine(arrNubmer1[i]);
            }

            //fore + tab
            foreach (var x in arrNubmer1)
            {
                Console.WriteLine(x);
                int temp = Convert.ToInt32(Console.ReadLine());
            } 
        /*
        Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
        
        Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điểm thông báo Trượt hoặc đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
        */






        }
    }
}
