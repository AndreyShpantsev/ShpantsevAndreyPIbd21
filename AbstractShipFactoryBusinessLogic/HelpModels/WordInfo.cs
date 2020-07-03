using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryBusinessLogic.HelpModels
{
    class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ShipViewModel> Ships { get; set; }
    }
}
