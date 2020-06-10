﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AbstractShipFactoryBusinessLogic.Enums;

namespace AbstractShipFactoryFileImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}
