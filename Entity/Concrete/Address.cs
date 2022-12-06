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
    public class Address : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string AddressLine { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Country { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string City  { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string District { get; set; }
        public int ZipCode  { get; set; }
        public bool Status   { get; set; }
        public DateTime CreationDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }




    }
}
