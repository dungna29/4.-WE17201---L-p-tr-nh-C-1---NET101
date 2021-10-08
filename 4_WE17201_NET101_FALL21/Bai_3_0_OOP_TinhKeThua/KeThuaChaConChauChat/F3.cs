using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua.KeThuaChaConChauChat
{
    class F3:F2
    {
        private string variable7;
        private string variable8;

        public F3()
        {
            
        }

        public F3(string variable1, string variable2, string variable3, string variable4, string variable5, string variable6, string variable7, string variable8) : base(variable1, variable2, variable3, variable4, variable5, variable6)
        {
            this.variable7 = variable7;
            this.variable8 = variable8;
        }

        public override void method1(string a, int b)
        {
            base.method1(a, b);
        }
    }
}
