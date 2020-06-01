using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryBusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int ShipId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
    }
}
