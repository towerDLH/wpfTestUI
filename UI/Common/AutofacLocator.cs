﻿using Autofac;
using System.Linq;
using System.Reflection;
using UI.Converter;
using UI.Interface;

namespace UI.Common
{
    public class AutofacLocator : IAutoFacLocator
    {
        IContainer container;

        public TInterface Get<TInterface>(string typeName)
        {
            return container.ResolveNamed<TInterface>(typeName);
        }

        public TInterface Get<TInterface>()
        {
            return container.Resolve<TInterface>();
        }

        public void Register()
        {
            var Container = new ContainerBuilder();
            Assembly asm = Assembly.GetExecutingAssembly();
            RegisterByAssembly(asm, ref Container);  //Auto Service
            //Container.RegisterType<UserService>().As<IUserService>();
            //Container.RegisterType<GroupService>().As<IGroupService>();
            //Container.RegisterType<MenuService>().As<IMenuService>();
            //Container.RegisterType<DictionaryService>().As<IDictionariesService>();
            //Container.RegisterType<MsgDlg>().As<IShowContent>();
            container = Container.Build();
        }

        public void Register(Assembly asb)
        {
            var Container = new ContainerBuilder();
            Assembly asm = asb;//Assembly.GetExecutingAssembly();
            RegisterByAssembly(asm, ref Container);  //Auto Service
            //Container.RegisterType<UserService>().As<IUserService>();
            //Container.RegisterType<GroupService>().As<IGroupService>();
            //Container.RegisterType<MenuService>().As<IMenuService>();
            //Container.RegisterType<DictionaryService>().As<IDictionariesService>();
            //Container.RegisterType<MsgDlg>().As<IShowContent>();
            container = Container.Build();
        }

        private void RegisterByAssembly(Assembly asm, ref ContainerBuilder Container)
        {
            var types = asm.GetTypes();
            foreach (var t in types)
            {
                var attr = (AutofacAttribute)t.GetCustomAttribute(typeof(AutofacAttribute), false);
                if (attr != null && attr.Allow)
                {
                    var interfaceDefault = t.GetInterfaces().FirstOrDefault();
                    if (interfaceDefault != null)
                    {
                        Container.RegisterType(t).Named(t.Name, interfaceDefault);
                    }
                }
            }
        }

    }
}
