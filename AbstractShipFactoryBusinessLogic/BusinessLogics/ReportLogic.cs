using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.HelpModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using System.Linq;

namespace AbstractShipFactoryBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IDetailLogic detailLogic;
        private readonly IShipLogic shipLogic;
        private readonly IOrderLogic orderLogic;

        public ReportLogic(IShipLogic shipLogic, IDetailLogic detailLogic,
       IOrderLogic orderLLogic)
        {
            this.shipLogic = shipLogic;
            this.detailLogic = detailLogic;
            this.orderLogic = orderLLogic;
        }

        public List<ReportShipDetailViewModel> GetShipDetail()
        {
            var ships = shipLogic.Read(null);
            var list = new List<ReportShipDetailViewModel>();
            foreach (var ship in ships)
            {
                var shipRec = new ReportShipDetailViewModel
                {
                    ShipName = ship.ShipName,
                    DetailName = " ",
                };
                list.Add(shipRec);
                foreach (var sh in ship.ShipDetails)
                {
                    var record = new ReportShipDetailViewModel
                    {
                        ShipName = " ",
                        DetailName = sh.Value.Item1,
                        TotalCount = sh.Value.Item2
                    };
                    list.Add(record);
                }
            }
            return list;
        }

        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            List<OrderViewModel> orders = orderLogic.Read(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            });
            return orders.GroupBy(o => o.DateCreate.ToShortDateString())
            .Select(g => new ReportOrdersViewModel
            {
                DateCreate = g.Key,
                OrdersSum = g.Select(o =>
                new Tuple<string, decimal>(o.ShipName, o.Sum)).ToList(),
                Sum = g.Sum(o => o.Sum)
            }).ToList();
        }

        public void SaveShipsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список судов",
                Ships = shipLogic.Read(null)
            });
        }
        public void SaveOrdersToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                Orders = GetOrders(model)
            });
        }

        [Obsolete]
        public void SaveShipDetailsToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список судов с деталями",
                ShipDetails = GetShipDetail()
            }) ;
        }
    }
}
