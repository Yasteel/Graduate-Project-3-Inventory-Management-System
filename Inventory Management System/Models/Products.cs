namespace Inventory_Management_System.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Products
    {
        [Key]
        [Column("pkProductId")]
        public int? ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public int? Quantity { get; set; }

        [Column("fkCategory")]
        public int? Category { get; set; }
    }
}
