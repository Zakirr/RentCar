using Melumatlar.Abstract;

namespace Entities.Concrete
{
    public class Customers : IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
