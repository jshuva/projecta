using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassGPublic : IInterfaceG
    {
        ClassG g = new ClassG();

        public void Method1()
        {
            g.Method1();
        }
    }
}
