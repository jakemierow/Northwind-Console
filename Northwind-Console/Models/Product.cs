using System;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Product
    {
        public int ProductID { get; set; }

       [Required(ErrorMessage = "Please enter a product name")]
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }

        [Required(ErrorMessage = "Please enter a unit price")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(-9999999999999999.99, 9999999999999999.99)]
        public decimal? UnitPrice { get; set; }

        [Required(ErrorMessage = "Please enter units in stock")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public Int16? UnitsInStock { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public Int16? UnitsOnOrder { get; set; }

        [Required(ErrorMessage = "Please enter the reorder level")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public Int16? ReorderLevel { get; set; }

        [Required(ErrorMessage = "Please enter Y or N")]
        public bool Discontinued { get; set; }

        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
