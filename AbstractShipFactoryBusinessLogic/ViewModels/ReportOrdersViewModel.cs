using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.Enums;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ReportOrdersViewModel
    {
        public string DateCreate { get; set; }
        public List<Tuple<string, decimal>> OrdersSum { get; set; }
        public decimal Sum { get; set; }

    }
}
