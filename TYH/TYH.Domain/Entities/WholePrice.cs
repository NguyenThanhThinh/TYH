﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class WholePrice : DomainEntity<int>
    {
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Product))]
        public virtual Product Product { get; set; }
    }
}
