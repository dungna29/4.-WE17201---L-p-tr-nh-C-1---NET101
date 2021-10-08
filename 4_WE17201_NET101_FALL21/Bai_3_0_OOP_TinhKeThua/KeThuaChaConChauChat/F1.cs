using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua.KeThuaChaConChauChat
{
    class F1:F0
    {
        private string variable3;
        private string variable4;

        public F1()
        {
            
        }

        
        public F1(string variable1, string variable2, string variable3, string variable4) : base(variable1, variable2)
        {
            this.variable3 = variable3;
            this.variable4 = variable4;
        }

        public string Variable3
        {
            get => variable3;
            set => variable3 = value;
        }

        public string Variable4
        {
            get => variable4;
            set => variable4 = value;
        }

        public override void method1(string a, int b)
        {
            base.method1(a, b);
        }

    }
}
