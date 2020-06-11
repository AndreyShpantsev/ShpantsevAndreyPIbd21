using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryBusinessLogic.BindingModels
{
    public class StorageDetailBindingModel
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int DetailId { get; set; }
        public int Count { get; set; }
    }
}
