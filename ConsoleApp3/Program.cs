// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAcces.Concrete.EfCarData;
using Entities.Concrete;
using Idareetme.Concrete;
using Melumatlar.Concrete.EfCarData;

CarTest();



static void CarTest()
{

    RentCarManager rm = new RentCarManager(new EfCarData());
    RentColorManager cm = new RentColorManager(new EfColorData());
    RentBrandManager bm = new RentBrandManager(new EfBrandData());
    RentalsManager rem = new RentalsManager(new EfRentalData());



    var result = rem.Add(new Rentals { CarId = 5, CustomerId = 6, Id = 9 });
    Console.WriteLine(result.Message);

}

