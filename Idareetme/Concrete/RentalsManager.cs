using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class RentalsManager: IRentalsManager
    {
        IRentalsData _rentalData;

        public RentalsManager(IRentalsData rentalData)
        {
            _rentalData = rentalData;
        }

        //KIRALAMA
        public IDataResult<Rentals> Add(Rentals rentals)
        {
            var result = _rentalData.GetAll(p => p.CarId == rentals.CarId);
            foreach (var item in result)
            {
                if (item.ReturnDate == null)
                {
                    return new DataErrorResult<Rentals>("Masin istifadededir");
                }
            }
            
            rentals.RentDate = DateTime.Now.ToString("d");
            _rentalData.Add(rentals);
            return new DataSuccessResult<Rentals>("Success:Masin kiraye verildi");
        }


        //GERI VERME
        public IDataResult<Rentals> Return(Rentals rentals)
        {
                var result = _rentalData.GetAll(p => p.CarId == rentals.CarId);
            foreach (var item in result)
            {
                if (item.ReturnDate == null)
                {
                    rentals.CustomerId = item.CustomerId;
                    rentals.Id = item.Id;
                    rentals.RentDate = item.RentDate;
                    rentals.ReturnDate = DateTime.Now.ToString("d");

                    _rentalData.Update(rentals);
                    return new DataSuccessResult<Rentals>("Success:Masin Qaytarildi");
                }
            }
                

            
                return new DataErrorResult<Rentals>("Error:Masin istifadede deyil");

        }
    }
}
