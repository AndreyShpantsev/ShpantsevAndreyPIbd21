using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace AbstractShipFactoryBusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        [DataMember]
        public int ClientId { set; get; }
        [DataMember]
        public int ShipId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
    }
}
