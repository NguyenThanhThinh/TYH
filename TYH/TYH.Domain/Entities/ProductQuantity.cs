﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TYH.Domain.Entities
{
    public class ProductQuantity : DomainEntity<int>
    {

        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Column(Order = 2)]
        public int SizeId { get; set; }


        [Column(Order = 3)]
        public int ColorId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(Product))]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(Size))]
        public virtual Size Size { get; set; }

        [ForeignKey(nameof(Color))]
        public virtual Color Color { get; set; }
    }
}
