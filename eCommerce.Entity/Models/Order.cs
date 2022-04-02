using eCommerce.Entity.Enumeratinos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Entity.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

       


    }
}
