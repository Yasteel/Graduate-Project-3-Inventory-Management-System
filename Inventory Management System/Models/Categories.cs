using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public class Categories
    {
        [Key]
        [Column("pkCategoryId")]
        public int CategoryId { get; set; }

        public string? Description { get; set; }
    }
}
