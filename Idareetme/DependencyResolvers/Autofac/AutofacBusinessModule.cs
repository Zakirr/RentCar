using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using CoreAndUtilites.Utilities.Interceptors;
using DataAcces.Abstract;
using DataAcces.Concrete.EfCarData;
using DataAcces.Concrete.EfData;
using Idareetme.Abstract;
using Idareetme.Concrete;
using Melumatlar.Abstract;
using Melumatlar.Concrete.EfCarData;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentCarManager>().As<IRentCarManager>().SingleInstance();
            builder.RegisterType<EfCarData>().As<ICarData>().SingleInstance();

            builder.RegisterType<CarImagesManager>().As<ICarImagesService>().SingleInstance();
            builder.RegisterType<EfCarImagesData>().As<ICarImagesData>().SingleInstance();

            builder.RegisterType<EfBrandData>().As<IBrandData>().SingleInstance();
            builder.RegisterType<RentBrandManager>().As<IRentBrandManager>().SingleInstance();

            builder.RegisterType<EfColorData>().As<IColorData>().SingleInstance();
            builder.RegisterType<RentColorManager>().As<IRentColorManager>().SingleInstance();

            builder.RegisterType<EfRentalData>().As<IRentalsData>().SingleInstance();
            builder.RegisterType<RentalsManager>().As<IRentalsManager>().SingleInstance();

            builder.RegisterType<EfUsersData>().As<IUsersData>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
