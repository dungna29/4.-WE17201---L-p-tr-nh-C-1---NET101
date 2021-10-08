using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua
{
    //SinhVien là lớp con
    class SinhVien :Nguoi //Sử dụng dấu : để kế thừa
    {
        //Lớp con chỉ cần khai báo các thuộc tính đặc trưng riêng
        private string msv;
        private double diemCsharp;

        public SinhVien()
        {
            
        }
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public SinhVien(string ten, string sdt, int ns, string cmt, string queQuan, string msv1, double diemCsharp) : base(ten, sdt, ns, cmt, queQuan)
        {
            msv = msv1;
            this.diemCsharp = diemCsharp;

            //This: Dùng để tham chiếu đến các thuộc tính và phương thức của lớp hiện tại
            //base: Dùng để tham chiếu đến các thuộc tính và phương thức của lớp cha
           
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        void method1()
        {
            Console.WriteLine(Ten + Cmt);
          
        }

        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.
        public override void inRaManHinh()
        {
            Console.WriteLine($"{Ten} | {Cmt} | {Ns} | {QueQuan} | {Sdt} | {msv} | {DiemCsharp}");
        }
    }
}
