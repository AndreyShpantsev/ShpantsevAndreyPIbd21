using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class StorageDetailViewModel
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int DetailId { get; set; }
        [DisplayName("Название детали")]
        public string DetailName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}
