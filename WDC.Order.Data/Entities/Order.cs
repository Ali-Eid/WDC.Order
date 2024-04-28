using System;
namespace WDC.Orders.Data.Entities
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
    }
}

