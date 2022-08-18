// See https://aka.ms/new-console-template for more information
using Girilenler.Concrete;
using Idareetme.Concrete;
using Melumatlar.Concrete.EfCarData;
using Girilenler.Concrete;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;

CarTest();



static void CarTest()
{
    var rengler = new string[] { "Qara", "Sari", "Qirmizi", "Ag", "Mavi" };
    RentCarManager rm = new RentCarManager(new EfCarData());
    RentColorManager cm = new RentColorManager(new EfColorData());
    //cm.Delete(new Color { ColorId = 5 });
    //rm.Delete(new Car { BrandId = 5, ColorId = 3, DailyPrice = 45, Id = 1, ModelYear = 2005 });
    //rm.Add(new Car { Id = 17, ModelYear = 2000,ColorId=15,BrandId=3,DailyPrice=24,Descripton="Masino" });
    //rm.Add(new Car { Id = 18, ModelYear = 2000,ColorId=16, BrandId = 3, DailyPrice = 24, Descripton = "Masino" });
    //rm.Add(new Car { Id = 19, ModelYear = 2000,ColorId=17, BrandId = 3, DailyPrice = 24, Descripton = "Masino" });
    //cm.Add(new Color { ColorId = 15, ColorName = "Qirmizi" });
    //cm.Add(new Color { ColorId = 16, ColorName = "Yasil" });
    //cm.Add(new Color { ColorId = 17, ColorName = "Sari" });

    var r = rm.Joins().ToList();
    foreach (var item in r)
    {
        Console.WriteLine(item.BrandId + " " + item.ColorId + " " + item.ColorName);
    }




}

