using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AbstractShipFactoryBusinessLogic.Enums;
using System.Runtime.Serialization;
using AbstractShipFactoryBusinessLogic.Attributes;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int? ImplementerId { get; set; }
        [DataMember]
        [Column(title: "Исполнитель", width: 100)]
        public string ImplementerFIO { get; set; }
        [DataMember]
        public int ShipId { get; set; }
        [DataMember]
        [Column(title: "Клиент", width: 150)]
        public string ClientLogin { get; set; }
        [DataMember]
        [Column(title: "Судно", width: 100)]
        public string ShipName { get; set; }
        [DataMember]
        [Column(title: "Количество", width: 100)]
        public int Count { get; set; }
        [DataMember]
        [Column(title: "Сумма", width: 50)]
        public decimal Sum { get; set; }
        [DataMember]
        [Column(title: "Статус", width: 100)]
        public OrderStatus Status { get; set; }
        [DataMember]
        [Column(title: "Дата создания", width: 100)]
        public DateTime DateCreate { get; set; }
        [DataMember]
        [Column(title: "Дата выполнения", width: 100)]
        public DateTime? DateImplement { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ClientId",
            "ImplementerFIO",
            "ShipName",
            "Count",
            "Sum",
            "Status",
            "DateCreate",
            "DateImplement"
        };
    }
}