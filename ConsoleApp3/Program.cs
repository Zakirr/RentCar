// See https://aka.ms/new-console-template for more information
using Girilenler.Concrete;
using Idareetme.Concrete;
using Melumatlar.Concrete.EfCarData;
using Girilenler.Concrete;

CarTest();



static void CarTest()
{
    RentCarManager rm = new RentCarManager(new EfColorData());
    //rm.Add(new Car { Id=35});
    rm.Add(new Color { ColorId = 15,ColorName="Qirmizi"});
}

