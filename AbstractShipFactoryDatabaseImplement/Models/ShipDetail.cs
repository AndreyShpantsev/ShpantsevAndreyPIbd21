using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractShipFactoryDatabaseImplement.Models
{
    public class ShipDetail
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public int DetailId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Detail Detail { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
