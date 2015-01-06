//using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA : IInterfaceA
    {
        IInterfaceS s;
        IInterfaceY y;

        public ClassA(IInterfaceS newS, IInterfaceY newY)
        {
            s = newS;
            y = newY;
        }

        public void Method1()
        {

        }

        public void Method2()
        {
            
            s.Method3();
            s.Method1();
        }

        public void Method3()
        {
            y.Method2();
        }
    }
}
