using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using CoreAndUtilites.Utilities.Interceptors;
using Idareetme.Abstract;
using Idareetme.Concrete;
using Melumatlar.Abstract;
using Melumatlar.Concrete.EfCarData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentCarManager>().As<IRentCarManager>().SingleInstance();
            builder.RegisterType<EfCarData>().As<ICarData>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
