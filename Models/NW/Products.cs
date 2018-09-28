using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMVC.Models.NW
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public string QuantityPerUnit { get; set; }
        [ScaffoldColumn(false)]
        public short? UnitsInStock { get; set; }
        [ScaffoldColumn(false)]
        public short? UnitsOnOrder { get; set; }
        [ScaffoldColumn(false)]
        public short? ReorderLevel { get; set; }
        [ScaffoldColumn(false)]
        public bool? Discontinued { get; set; }

        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
