using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity框架.Models;

namespace Unity框架.UnityClass
{
    class dep
    {
        public static void ContainerCodeTest1()
        {
            IUnityContainer container = new UnityContainer();
            //默认注册（无命名）,如果后面还有默认注册会覆盖前面的
            container.RegisterType<IClass, CbClass>();
            //命名注册
            container.RegisterType<IClass, EcClass>("ec");
            //解析默认对象
            IClass cbClass = container.Resolve<IClass>();
            cbClass.ShowInfo();
            //指定命名解析对象
            IClass ecClass = container.Resolve<IClass>("ec");
            ecClass.ShowInfo();
            //获取容器中所有IClass的注册的已命名对象
            IEnumerable<IClass> classList = container.ResolveAll<IClass>();
            foreach (var item in classList)
            {
                item.ShowInfo();
            }
        }
    }
}
