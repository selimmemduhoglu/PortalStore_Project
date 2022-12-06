using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderItem : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal UnitPrice { get; set; }
        public int Quality { get; set; }
        public bool Status { get; set; }
        public int SkuId { get; set; }
        public SKU SKU { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
       


    }
}
