using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractShipFactoryDatabaseImplement.Models
{
    public class Ship
    {
        public int Id { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("ShipId")]
        public virtual List<ShipDetail> ShipDetails { get; set; }

        [ForeignKey("ShipId")]
        public virtual List<Order> Orders { get; set; }

    }
}
