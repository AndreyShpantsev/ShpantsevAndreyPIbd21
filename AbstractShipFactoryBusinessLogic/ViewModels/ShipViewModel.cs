using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ShipViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название судна")] 
        public string ShipName { get; set; }

        [DisplayName("Цена")] 
        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> ShipDetails { get; set; }
    }
}
