using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractShipFactoryListImplement.Models;


namespace AbstractShipFactoryListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Detail> Details { get; set; }
        public List<Order> Orders { get; set; }
        public List<Ship> Ships { get; set; }
        public List<ShipDetail> ShipDetails { get; set; }
        private DataListSingleton()
        { 
            Details = new List<Detail>();
            Orders = new List<Order>();
            Ships = new List<Ship>();
            ShipDetails = new List<ShipDetail>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
