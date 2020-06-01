using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AbstractShipFactoryBusinessLogic.Enums;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int ShipId { get; set; }

        [DisplayName("Судно")] 
        public string ShipName { get; set; }

        [DisplayName("Количество")] 
        public int Count { get; set; }

        [DisplayName("Сумма")] 
        public decimal Sum { get; set; }

        [DisplayName("Статус")] 
        public OrderStatus Status { get; set; }

        [DisplayName("Дата создания")] 
        public DateTime DateCreate { get; set; }

        [DisplayName("Дата выполнения")] 
        public DateTime? DateImplement { get; set; }
    }
}
