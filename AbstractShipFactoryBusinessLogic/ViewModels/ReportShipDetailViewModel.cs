using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ReportShipDetailViewModel
    {
        public string ShipName { get; set; }
        public string DetailName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> Details { get; set; }
    }
}
