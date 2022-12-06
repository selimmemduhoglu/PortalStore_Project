using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SKU : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal OldPrice { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }



    }
}
