using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package3;
using Package2;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterfaceSomething>().To<ClassM>();
            
            Bind<IInterfaceS>().To<ClassS>();
            
            Bind<IInterfaceY>().To<ClassY>();

            Bind<IInterfaceA>().To<ClassA>();

            Bind<IInterfaceP>().To<ClassP>();

            Bind<IInterfaceE>().To<ClassE>();

            Bind<IInterfaceR>().To<ClassR>();

            Bind<IInterfaceX>().To<ClassX>();

            Bind<IInterfaceT>().To<ClassT>();

            Bind<IInterfaceK>().To<ClassK>();

            Bind<IInterfaceJ>().To<ClassJ>();

            Bind<IInterfaceC>().To<ClassC>();

            Bind<IInterfaceQ>().To<ClassQ>();

            Bind<IInterfaceG>().To<ClassGPublic>();



        }
    }
}
