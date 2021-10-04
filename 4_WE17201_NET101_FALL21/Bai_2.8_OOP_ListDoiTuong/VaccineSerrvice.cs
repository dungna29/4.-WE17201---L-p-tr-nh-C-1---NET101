using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._8_OOP_ListDoiTuong
{
    class VaccineSerrvice
    {
        private String _input;
        private Vaccine _vaccine;
        private List<Vaccine> _lstVaccines;//Khởi tạo 1 biến toàn cục có kiểu dữ liệu đối tượng
        public VaccineSerrvice()
        {
            _lstVaccines = new List<Vaccine>();
            them3DataFake();
        }

        void them3DataFake()
        {
            _lstVaccines.Add(new Vaccine("VN1","VNVID","VN",6));
            _lstVaccines.Add(new Vaccine("CB1","VNCBVID","CUBA",9));
            _lstVaccines.Add(new Vaccine("RUS1","RUSVID","NGA",12));
        }

        public void addVaccine()
        {
            Console.WriteLine("Bạn muốn thêm bao nhiêu Vaccine: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _vaccine = new Vaccine();//Khởi tạo 1 đối tượng
                Console.WriteLine("Mời bạn nhập mã: ");
                _vaccine.MaVaccine = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tên: ");
                _vaccine.TenVaccine = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nsx: ");
                _vaccine.Nsx = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập thời hạn tác dụng: ");
                _vaccine.ThoiGianTacDung = Convert.ToInt32(Console.ReadLine());
                //Sau khi gán giá trị của đối tượng do người dùng nhập vào tiến hành add đối tượng vào List
                _lstVaccines.Add(_vaccine);
            }
        }

        public void xoaVaccine()
        {
            Console.WriteLine("Hãy nhập mã VC: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);//Trả vị trí của đối tượng
            if (temp < 0)
            {
                Console.WriteLine("Vaccine không tìm thấy");
                return;
            }
            _lstVaccines.RemoveAt(temp);
            Console.WriteLine("Xóa thành công");
        }
        public void timVaccine()
        {
            Console.WriteLine("Hãy nhập mã VC: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);//Trả vị trí của đối tượng
            if (temp < 0)
            {
                Console.WriteLine("Vaccine không tìm thấy");
                return;
            }
            _lstVaccines[temp].inRaManHinh();
        }
        public void suaVaccine()
        {
            Console.WriteLine("Hãy nhập mã VC: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);//Trả vị trí của đối tượng
            if (temp < 0)
            {
                Console.WriteLine("Vaccine không tìm thấy");
                return;
            }

            Console.WriteLine("Mời bạn nhập tên Vaccine cần sửa: ");
            _lstVaccines[temp].TenVaccine = Console.ReadLine();
            Console.WriteLine("Sủa thành công");
        }

        public void getLstVaccine()
        {
            foreach (var x in _lstVaccines)
            {
                x.inRaManHinh();
            }
        }
        public void TimKiemNangCaoLstVaccine()
        {
            Console.WriteLine("Nhập Mã hoặc Tên Hoặc Nsx để tìm: ");
            _input = Console.ReadLine();
            foreach (var x in _lstVaccines.Where(c=>c.TenVaccine.ToLower().StartsWith(_input.ToLower()) ||
                c.MaVaccine.ToLower().StartsWith(_input.ToLower())))
            {
                x.inRaManHinh();
            }
        }
        public void getLstVaccineOrder()//Xuất danh sách đã sắp xếp
        {
            foreach (var x in _lstVaccines.OrderBy(c=>c.ThoiGianTacDung))
            {
                x.inRaManHinh();
            }
        }

        int getIndex(string mavc)
        {
            for (int i = 0; i < _lstVaccines.Count; i++)
            {
                if (_lstVaccines[i].MaVaccine == mavc)
                {
                    return i;
                }
            }
            return -5;
        }
    }
}
