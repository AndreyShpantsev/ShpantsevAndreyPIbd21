using AbstractShipFactoryBusinessLogic.Enums;
using AbstractShipFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AbstractShipFactoryFileImplement
{
    public class ShipFactoryFileDataListSingleton
    {
        private static ShipFactoryFileDataListSingleton instance;
        private readonly string DetailFileName = "Detail.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string ShipFileName = "Ship.xml";
        private readonly string ShipDetailFileName = "ShipDetail.xml";
        public List<Detail> Details { get; set; }
        public List<Order> Orders { get; set; }
        public List<Ship> Ships { get; set; }
        public List<ShipDetail> ShipDetails { get; set; }

        private ShipFactoryFileDataListSingleton()
        {
            Details = LoadDetails();
            Orders = LoadOrders();
            Ships = LoadShips();
            ShipDetails = LoadShipDetails();
        }
        public static ShipFactoryFileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new ShipFactoryFileDataListSingleton();
            }
            return instance;
        }
        ~ShipFactoryFileDataListSingleton()
        {
            SaveDetails();
            SaveOrders();
            SaveShips();
            SaveShipDetails();
        }

        private List<Detail> LoadDetails()
        {
            var list = new List<Detail>();
            if (File.Exists(DetailFileName))
            {
                XDocument xDocument = XDocument.Load(DetailFileName);
                var xElements = xDocument.Root.Elements("Detail").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Detail
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        DetailName = elem.Element("DetailName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                XDocument xDocument = XDocument.Load(OrderFileName);
                var xElements = xDocument.Root.Elements("Order").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ShipId = Convert.ToInt32(elem.Element("ShipId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
                        DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
                        DateImplement = string.IsNullOrEmpty(elem.Element("DateImplement").Value) ? (DateTime?)null : 
                        Convert.ToDateTime(elem.Element("DateImplement").Value),
                    });
                }
            }
            return list;
        }

        private List<Ship> LoadShips()
        { 
            var list = new List<Ship>();
            if (File.Exists(ShipFileName))
            {
                XDocument xDocument = XDocument.Load(ShipFileName);
                var xElements = xDocument.Root.Elements("Ship").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Ship
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ShipName = elem.Element("ShipName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value)
                    });
                }
            }
            return list;
        }
        private List<ShipDetail> LoadShipDetails()
        {
            var list = new List<ShipDetail>();
            if (File.Exists(ShipDetailFileName))
            {
                XDocument xDocument = XDocument.Load(ShipDetailFileName);
                var xElements = xDocument.Root.Elements("ShipDetail").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new ShipDetail
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ShipId = Convert.ToInt32(elem.Element("ShipId").Value),
                        DetailId = Convert.ToInt32(elem.Element("DetailId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value)
                    });
                }
            }
            return list;
        }
        private void SaveDetails()
        {
            if (Details != null)
            {
                var xElement = new XElement("Details");
                foreach (var detail in Details)
                {
                    xElement.Add(new XElement("Detail",
                    new XAttribute("Id", detail.Id),
                    new XElement("DetailName", detail.DetailName)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(DetailFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");
                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                    new XAttribute("Id", order.Id),
                    new XElement("ShipId", order.ShipId),
                    new XElement("Count", order.Count),
                    new XElement("Sum", order.Sum),
                    new XElement("Status", order.Status),
                    new XElement("DateCreate", order.DateCreate),
                    new XElement("DateImplement", order.DateImplement)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveShips()
        {
            if (Ships != null)
            {
                var xElement = new XElement("Ships");
                foreach (var ship in Ships)
                {
                    xElement.Add(new XElement("Ship",
                    new XAttribute("Id", ship.Id),
                    new XElement("ShipName", ship.ShipName),
                    new XElement("Price", ship.Price)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ShipFileName);
            }
        }
        private void SaveShipDetails()
        { 
            if (ShipDetails != null)
            {
                var xElement = new XElement("ShipDetails");
                foreach (var shipDetail in ShipDetails)
                {
                    xElement.Add(new XElement("ShipDetail",
                    new XAttribute("Id", shipDetail.Id),
                    new XElement("ShipId", shipDetail.ShipId),
                    new XElement("DetailId", shipDetail.DetailId),
                    new XElement("Count", shipDetail.Count)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ShipDetailFileName);
            }
        }
    }
}
