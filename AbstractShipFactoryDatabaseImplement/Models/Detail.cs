using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractShipFactoryDatabaseImplement.Models
{
    public class Detail
    {
        public int Id { get; set; }

        [Required]
        public string DetailName { get; set; }

        [ForeignKey("DetailId")]
        public virtual List<ShipDetail> ShipDetails { get; set; }
    }
}
