using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_0_OOP_TinhKeThua.KeThuaChaConChauChat
{
    class F0
    {
        private string variable1;
        private string variable2;

        public F0()
        {
        }

        public F0(string variable1, string variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
        }

        public string Variable1
        {
            get => variable1;
            set => variable1 = value;
        }

        public string Variable2
        {
            get => variable2;
            set => variable2 = value;
        }
        //Có từ khóa vitual để giúp cho thằng con khi kế thừa lại có thể ghi đè phương thức
        public virtual void method1(string a, int b)
        {

        }
        private void method2(string a, int b)
        {

        }

       
    }
}
