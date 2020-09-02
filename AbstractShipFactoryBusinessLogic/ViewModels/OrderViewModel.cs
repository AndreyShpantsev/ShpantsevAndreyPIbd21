using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AbstractShipFactoryBusinessLogic.Enums;
using System.Runtime.Serialization;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int ShipId { get; set; }
        [DataMember]
        [DisplayName("Клиент")]
        public string ClientLogin { get; set; }
        [DataMember]
        [DisplayName("Судно")] 
        public string ShipName { get; set; }
        [DataMember]
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DataMember]
        [DisplayName("Сумма")] 
        public decimal Sum { get; set; }
        [DataMember]
        [DisplayName("Статус")] 
        public OrderStatus Status { get; set; }
        [DataMember]
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DataMember]
        [DisplayName("Дата выполнения")] 
        public DateTime? DateImplement { get; set; }
    }
}
