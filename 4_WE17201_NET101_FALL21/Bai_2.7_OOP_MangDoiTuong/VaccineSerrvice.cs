using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._7_OOP_MangDoiTuong
{
    class VaccineSerrvice//Đây sẽ là nơi code các chức năng như thêm, sửa, xóa... Vaccine
    {
        //private int[] arrNumber = new int[5]; tự so sánh
        private Vaccine[] _arrVaccines;//Khai báo
        private string _input;
        public VaccineSerrvice()
        {

        }

        //Chức năng để thêm đối tượng
        public void themVaccine()
        {
            Console.WriteLine("Bạn muốn thêm bao nhiêu Vaccine: ");
            _input = Console.ReadLine();
            _arrVaccines = new Vaccine[Convert.ToInt32(_input)];//Khởi tạo 1 mảng đối tượng
            for (int i = 0; i < _arrVaccines.Length; i++)
            {
                _arrVaccines[i] = new Vaccine();//Muốn sửa dụng phải khởi tạo đối tượng
                //_arrVaccines[i] = 1 đối tượng Vaccine nằm ở vị trí
                Console.WriteLine("Mời bạn nhập tên: ");
                _arrVaccines[i].TenVaccine = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nsx: ");
                _arrVaccines[i].Nsx = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập thời gian tác dụng: ");
                _arrVaccines[i].ThoiGianTacDung = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void suaVccine()
        {
            //Chỉ cho phép sửa 2 thuộc tính là nhà sản xuất và thời hạn tác dụng
            //Bước 1: Cần phải tìm xem tên Vacxin có tồn tại hay không?
            Console.WriteLine("Mời bạn nhập vào tên vacxin: ");
            _input = Console.ReadLine();
            //Kiểm tra xem tên có trong mảng hay không?
            for (int i = 0; i < _arrVaccines.Length; i++)
            {
                if (_arrVaccines[i].TenVaccine == _input)//Khi tìm thấy tên vacxin thì mới tiến hành sửa
                {
                    Console.WriteLine("Mời bạn chọn thông tin cần sửa");
                    Console.WriteLine("1. Nhà sản xuất");
                    Console.WriteLine("2. Thời hạn tác dụng");
                    Console.WriteLine("Nhập chức năng: ");
                    _input = Console.ReadLine();
                    switch (_input)
                    {
                        case "1":
                            Console.WriteLine("Mời bạn nhập nhà sản xuất mới: ");
                            _arrVaccines[i].Nsx = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Mời bạn nhập thời hạn tác dụng: ");
                            _arrVaccines[i].ThoiGianTacDung = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    return;//Sau khi đã tìm thấy và sửa xong thì sẽ kết thúc luôn phương thức sửa.
                }
            }
            Console.WriteLine("Không tìm thấy loại Vaccine bạn cần");
        }
        public void xoaVccine()
        {
            Console.WriteLine("Mời bạn nhập vào tên vacxin: ");
            _input = Console.ReadLine();
            // for (int i = 0; i < _arrVaccines.Length; i++)
            // {
            //     if (_arrVaccines[i].TenVaccine == _input)
            //     {
            //         _arrVaccines[i] = new Vaccine();//Khi tìm thấy khởi tạo lại nó thì các dữ liệu bên trong thuộc tính sẽ clear.
            //         return;
            //     }
            // }

            //Cách 2: Sử dụng LINQ
            _arrVaccines[_arrVaccines.ToList().FindIndex(c => c.TenVaccine == _input)] = new Vaccine();
            Console.WriteLine("Không tìm thấy loại Vaccine bạn cần");
        }
        public void timKiemVaccine()
        {
            Console.WriteLine("Mời bạn nhập vào tên vacxin: ");
            _input = Console.ReadLine();
            _arrVaccines[_arrVaccines.ToList().FindIndex(c => c.TenVaccine == _input)].inRaManHinh();
            // for (int i = 0; i < _arrVaccines.Length; i++)
            // {
            //     if (_arrVaccines[i].TenVaccine == _input)
            //     {
            //         _arrVaccines[i].inRaManHinh();
            //         return;
            //     }
            // }
            Console.WriteLine("Không tìm thấy loại Vaccine bạn cần");
        }
        public void inDsVaccine()
        {
            foreach (var x in _arrVaccines.OrderByDescending(c=>c.Nsx))
            {
                x.inRaManHinh();
            }
        }
    }
}
