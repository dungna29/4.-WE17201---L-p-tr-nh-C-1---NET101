using System;
using System.Text;
using System.Threading.Channels;

namespace Bai_2_9_Method_PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Phương thức không trả về void

            Void_PhuongThucKhongTraVe ptkhongTrave = new Void_PhuongThucKhongTraVe();
            /*
          * 1. Hướng dẫn sử dụng phương thức không trả về không tham số:
          *      - Cần biết tên phương thức và phương thức đó đang nằm trong class nào.
          *      - Khi gọi ra kết thúc phải ();
          */
            //ptkhongTrave.tinhTong; lỗi khi sử dụng thiếu ();

            ptkhongTrave.tinhTong();

            /*
            * 2. Sử dụng phương thức không trả có tham số:
            *      - Bắt buộc truyền đúng thứ tự vị trí tham số và đúng kiểu dữ liệu
            *      - Bắt buộc phải truyền tham số nếu phương thức có
            *      - Nếu là nạp chồng phương thức thì truyền số lượng tham số sẽ gọi phương thức cần gọi
            */
            //ptkhongTrave.tinhTong2So(1); Truyền thiếu tham số 
            ptkhongTrave.tinhTongCacSo(5,5);
            ptkhongTrave.tinhTongCacSo(5,5,5,5);
            #endregion

          
            #region Phần 2: Phương thức trả về
            //Cashc dùng giống void
            PhuongThucTraVe pv = new PhuongThucTraVe();
            pv.tinhTong();//Phương thức trả về là 1 giá trị nên không thể tự in nó
            Console.WriteLine(pv.tinhTong() + 6000);//In giá trị và có thể thực hiện phép toán nếu nó là số

            int[] arrTemp = pv.getAllYears();
            foreach (var x in arrTemp)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(pv.getSinhVien().thuocTinhSV);
            #endregion
        }
    }
}
