using Melumatlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rentals:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string RentDate { get; set; }
        public string? ReturnDate { get; set; }
        public int CarId { get; set; }

    }
}
