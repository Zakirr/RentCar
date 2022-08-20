// See https://aka.ms/new-console-template for more information
using Girilenler.Concrete;
using Idareetme.Concrete;
using Melumatlar.Concrete.EfCarData;
using Girilenler.Concrete;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using Utilites.Concrete;
using DataAcces.Concrete.EfCarData;

CarTest();



static void CarTest()
{

    RentCarManager rm = new RentCarManager(new EfCarData());
    RentColorManager cm = new RentColorManager(new EfColorData());
    RentBrandManager bm = new RentBrandManager(new EfBrandData());
    RentalsManager rem = new RentalsManager(new EfRentalData());


   
    var result = rem.Add(new Rentals { CarId = 5,CustomerId=6,Id=9 });
    Console.WriteLine(result.Message);

}

