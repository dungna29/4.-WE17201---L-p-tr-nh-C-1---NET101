using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    interface ISinhVienService
    {
        //1. Không được phép khai báo private. Mặc định là public
        //2. Các phương thức cũng ko có body code
        void them();
        void sua();
        void xoa();
        List<SinhVien> getlst();

    }
}
