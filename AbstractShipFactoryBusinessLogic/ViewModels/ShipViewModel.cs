using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using AbstractShipFactoryBusinessLogic.Attributes;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ShipViewModel:BaseViewModel
    {
        [Column(title: "Название судна", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string ShipName { get; set; }
        [Column(title: "Цена", width: 50)]
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> ShipDetails { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ShipName",
            "Price"
        };
    }
}