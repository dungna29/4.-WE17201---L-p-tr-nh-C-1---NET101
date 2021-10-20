using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CHUA_BAI_THI_THU
{
    class QLVC
    {
        private string _input;
        private Vaccine _vaccine;
        private List<Vaccine> _lstVaccines;
        public QLVC()
        {
            _lstVaccines = new List<Vaccine>();
        }

        public void add()
        {
            do
            {
                Console.WriteLine("Mời bạn nhập số lượng: ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _vaccine = new Vaccine();
                    Console.WriteLine("Mời bạn nhập mã: ");
                    _vaccine.MaVc = Console.ReadLine(); Console.WriteLine("Mời bạn nhập tên: ");
                    _vaccine.TenVc = Console.ReadLine(); Console.WriteLine("Mời bạn nhập thời gian tác dụng: ");
                    _vaccine.ThoiGianTacDung = float.Parse(Console.ReadLine()); Console.WriteLine("Mời bạn nhập ngày hết hạn: ");
                    _vaccine.NgayHetHan = Console.ReadLine();
                    _lstVaccines.Add(_vaccine);
                }

                Console.WriteLine("Bạn có muốn nhập tiếp hay không? 1. Có | 2. Không");
                _input = Console.ReadLine();
                if (_input == "2") break;
            } while (true);//!(_input == "2")
        }
        public void inDs()
        {
            foreach (var x in _lstVaccines)
            {
                x.InRaManHinh();
            }
        }
        public void inDsDK()
        {
            foreach (var x in _lstVaccines)
            {
                if (x.ThoiGianTacDung > 6)
                {
                    x.InRaManHinh();
                }

            }
            //Cách 2: 
            foreach (var x in _lstVaccines.Where(c => c.ThoiGianTacDung > 6))
            {
                x.InRaManHinh();
            }
        }
        public void inDsSort()
        {
            //Cách dùng LINQ để sort
            var temp = _lstVaccines.OrderByDescending(c => c.ThoiGianTacDung).ToList();
            _lstVaccines = new List<Vaccine>();
            _lstVaccines = temp;
            Console.WriteLine("Thành công");

            //Cách 2: Sort
            _lstVaccines.Sort((c1,c2)=>c1.ThoiGianTacDung.CompareTo(c2.ThoiGianTacDung));
            _lstVaccines.Reverse();
        }

        public string getValueInput(string temp)
        {
            return Console.ReadLine();
        }
        public int getIndex(string temp)
        {
            return _lstVaccines.FindIndex(c => c.MaVc == temp);
        }
        public void cnKeThua()
        {
            VaccineVN vn = new VaccineVN();
            vn.MaVc = "123";
            vn.TenVc = "123";
            vn.ThoiGianTacDung = 5;
            vn.NgayHetHan = "123";
            vn.QuocGia = "123";
            vn.InRaManHinh();
        }
    }
}
