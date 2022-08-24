using Melumatlar.Abstract;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class CarImages : IEntity
    {
        public int Id { get; set; }
        public int? CarId { get; set; }
        public string? Date { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile files { get; set; }
    }
}
