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
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal TotalPrice { get; set; }
        public bool Status  { get; set; }
        public DateTime CreationDate { get; set; }
        public int AddressId   { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }







    }
}
