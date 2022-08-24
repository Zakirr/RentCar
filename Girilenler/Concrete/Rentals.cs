using Melumatlar.Abstract;

namespace Entities.Concrete
{
    public class Rentals : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? RentDate { get; set; }
        public string? ReturnDate { get; set; }
        public int CarId { get; set; }

    }
}
