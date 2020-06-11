using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryBusinessLogic.BindingModels
{
    public class StorageBindingModel
    {
        public int Id { get; set; }
        public string StorageName { get; set; }
        public List<StorageDetailBindingModel> StorageDetails { get; set; }
    }
}
