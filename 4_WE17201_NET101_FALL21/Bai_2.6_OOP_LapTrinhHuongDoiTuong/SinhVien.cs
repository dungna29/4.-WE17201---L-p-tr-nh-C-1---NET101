using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_OOP_LapTrinhHuongDoiTuong
{
    //1. Đối tượng là danh từ và viết hoa chữ cái đầu của từ
    class SinhVien
    {
        //Phần 1. Liệt kê toàn bộ các thuộc tính mà đối tượng phải có
        private string ten;
        private string msv;
        private int ns;
        private string truong = "Fpoly";

        //Phần 2: Contructor (Hàm tạm)
        /*
         * 1 - Contructor giống với tên đối tượng
         * 2 - Contructor là thành phần được chạy vào đầu tiên khi khởi tạo đối tượng.
         * 3 - Khi mới học mỗi đối tượng luôn có 2 Contructor 1 là có tham số 2 là không tham số.
         * 4 - Khi lớp đối tượng không có Conctructor thì khi khởi tạo bên ngoài sẽ tự động tạo ra 1 contructor không tham số mặc định.
         */
        //Contructor không tham số ctor + tab
        public SinhVien()
        {
            // Console.WriteLine("Đây là contructor đang chạy");
        }

        //Contructor có tham số sẽ phải khởi tạo giá trị cho thuộc tính đối tượng khi sử dụng
        /*
       Nếu bạn nào dùng resharper ctorf + tab
       Đối với các bạn không cài resharper muốn gọi contructor có tham số:
          1. Chuột phải vào Class đối tượng chọn Quick Actions....
          2. Generate Contructor và bấm ok
       */
        public SinhVien(string ten, string msv, int ns)
        {
            this.ten = ten;
            this.msv = msv;
            this.ns = ns;
           
        }
        //Phần 3: Triển khai property của thuộc tính
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         */
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public string Truong
        {
            get => truong;
            //set => truong = value;
        }

        //Phần 4: Triển khai các phương thức của đối tượng
        public void inRaManHinh()
        {
            Console.WriteLine("{0} {1} {2} {3}",ten,msv,ns,truong);
        }
    }
}
