using Entities.Abstract;

namespace Entities.Concrete
{
    public class DtoS : IDtoS
    {

        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
    }
}
