using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<EFAddressDal>().As<IAddressDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EFCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerCheckService>();
            builder.RegisterType<EFAddressDal>().As<ICustomerDal>();

            builder.RegisterType<OrderItemManager>().As<IOrderItemService>();
            builder.RegisterType<EFOrderItemDal>().As<IOrderItemDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EFOrderDal>().As<IOrderDal>();

            builder.RegisterType<SKUManager>().As<ISKUService>();
            builder.RegisterType<EFSKUDal>().As<ISKUDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
