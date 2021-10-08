using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua.KeThuaChaConChauChat
{
    class F2:F1
    {
        private string variable5;
        private string variable6;

        public F2()
        {
            
        }

        public F2(string variable1, string variable2, string variable3, string variable4, string variable5, string variable6) : base(variable1, variable2, variable3, variable4)
        {
            this.variable5 = variable5;
            this.variable6 = variable6;
        }

        public string Variable5
        {
            get => variable5;
            set => variable5 = value;
        }

        public string Variable6
        {
            get => variable6;
            set => variable6 = value;
        }

        public override void method1(string a, int b)
        {
            base.method1(a, b);
        }
    }
}
