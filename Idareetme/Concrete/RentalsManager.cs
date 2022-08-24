using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsManager
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
            rentals.ReturnDate = null;
            _rentalData.Add(rentals);
            return new DataSuccessResult<Rentals>("Success:Masin kiraye verildi");
        }

        public IDataResult<List<Rentals>> GetAll()
        {

            return new DataSuccessResult<List<Rentals>>(_rentalData.GetAll());
        }


        //GERI VERME
        public IDataResult<Rentals> Return(Rentals rentals)
        {
            var result = _rentalData.Get(p => p.Id == rentals.Id && p.ReturnDate == null);

            if (result != null)
            {

                rentals.CustomerId = result.CustomerId;
                rentals.CarId = result.CarId;
                rentals.RentDate = result.RentDate;
                rentals.ReturnDate = DateTime.Now.ToString("d");

                _rentalData.Update(rentals);
                return new DataSuccessResult<Rentals>("Success:Masin Qaytarildi");
            }





            return new DataErrorResult<Rentals>("Error:Masin istifadede deyil");

        }
    }
}
