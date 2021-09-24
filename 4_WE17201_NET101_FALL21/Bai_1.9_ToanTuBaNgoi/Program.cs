using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._9_ToanTuBaNgoi
{
    class Program
    {
        /*
        * TOÁN TỬ 3 NGÔI
        * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 9 > 8 ? "Đúng" : "Sai";
            int temp2 = 9 > 8 ? 1 : 0;
            bool temp3 = 9 > 8 ? true : false;
            double temp4 = 9 > 8 ? 1.0 : 0.5;
            Console.WriteLine(temp1);
            double diem = 7.9;
            string kq = (diem == 10) ? "Xuất sắc" : 
                (diem >= 8 && diem < 10) ? "Giỏi" : 
                (diem >= 7 && diem < 8) ? "Khá" : 
                (diem >= 5 && diem < 7) ? "Yếu" : "Học lại";
            Console.WriteLine(kq);
            /*
             * Bài tập: Viết 1 chương trình khi nhập thông tin 1 người bạn xác định được là ANH, CHỊ, EM, BẠN.
             * Cố định lại Tuổi và Giới Tính của bản thân
             */
            int namSinhBanThan = 2002, gioiTinh = 1;//Cố định 1 = Nam | 0 = Nữ
            //Yêu cầu nhập vào TÊN - NĂM SINH - GIỚI TÍNH có thể xác định được tên gọi như ở trên.
            //+1 điểm vào ASS1 cho 4 bạn code nhanh và đúng nhất sử dụng toán tử 3 ngồi.
            while (true)
            {
                string ten;
                int ns, gt;
                Console.WriteLine("Mời nhập tên: ");
                ten = Console.ReadLine();
                Console.WriteLine("Mời nhập năm sinh: ");
                ns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập giới tính: ");
                gt = Convert.ToInt32(Console.ReadLine());
                string kq1 = "Chào " + ((ns < namSinhBanThan && gt == 1) ? "Anh" :
                    (ns < namSinhBanThan && gt == 0) ? "Chị" :
                    (ns == namSinhBanThan) ? "Bạn" : "Em").ToString();
                Console.WriteLine(kq1);
            }
        }
        /*
           * Viết 1 chương trình nhập điểm GPA C#1
           * Nếu điểm từ 10 = Xuất sắc
           * Nếu điểm từ 8 đến 9 = giỏi
           * Nếu điểm từ 7 đến 8 = khá        
           * Nếu điểm từ 5 đến 6 = Yếu
           * Nếu điểm từ 0 đến 5 = Học lại          
           */
    }
}
