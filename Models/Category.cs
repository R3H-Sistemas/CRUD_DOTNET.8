using System.ComponentModel.DataAnnotations;

namespace CRUD_Dotnet.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
