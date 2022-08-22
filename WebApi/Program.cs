using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAcces.Abstract;
using DataAcces.Concrete.EfCarData;
using Idareetme.Abstract;
using Idareetme.Concrete;
using Melumatlar.Abstract;
using Melumatlar.Concrete.EfCarData;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var add=builder.Services.AddControllers();
            //builder.Services.AddSingleton<ICarData, EfCarData>();
            //builder.Services.AddSingleton<IColorData, EfColorData>();
            //builder.Services.AddSingleton<IBrandData, EfBrandData>();
            //builder.Services.AddSingleton<IRentalsData, EfRentalData>();
            //builder.Services.AddSingleton<IRentColorManager, RentColorManager>();
            //builder.Services.AddSingleton<IRentalsManager, RentalsManager>();
            //builder.Services.AddSingleton<IRentCarManager, RentCarManager>();
            //builder.Services.AddSingleton<IRentBrandManager, RentBrandManager>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(options =>
            {
                options.RegisterModule(new AutofacBusinessModule());
               
            });
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}