using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryBusinessLogic.BindingModels
{
    public class ShipBindingModel
    {
        public int? Id { get; set; }

        public string ShipName { get; set; }

        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> ShipDetails { get; set; }
    }
}
