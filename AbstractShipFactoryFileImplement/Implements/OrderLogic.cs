﻿using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Enums;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractShipFactoryFileImplement.Implements
{
    public class OrderLogic : IOrderLogic
    {
        private readonly ShipFactoryFileDataListSingleton source;

        public OrderLogic()
        {
            source = ShipFactoryFileDataListSingleton.GetInstance();
        }

        public void CreateOrUpdate(OrderBindingModel model)
        {
            Order element;
            if (model.Id.HasValue)
            {
                element = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Заказ не найден");
                }
            }
            else
            {
                int maxId = source.Orders.Count > 0 ? source.Orders.Max(rec => rec.Id) : 0;
                element = new Order { Id = maxId + 1 };
                source.Orders.Add(element);
            }
            element.ShipId = model.ShipId;
            element.ClientId = model.ClientId.Value;
            element.ImplementerId = model.ImplementerId;
            element.Count = model.Count;
            element.Sum = model.Sum;
            element.Status = model.Status;
            element.DateCreate = model.DateCreate;
            element.DateImplement = model.DateImplement;
        }

        public void Delete(OrderBindingModel model)
        {
            Order element = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Orders.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            return source.Orders
           .Where(rec => model == null || rec.Id == model.Id
           || rec.DateCreate >= model.DateFrom.Value
           && rec.DateCreate <= model.DateTo.Value
           || model.ClientId.HasValue && model.ClientId == rec.ClientId
           || model.FreeOrders.HasValue && model.FreeOrders.Value &&
           !rec.ImplementerId.HasValue
           || model.ImplementerId.HasValue && rec.ImplementerId ==
            model.ImplementerId && rec.Status == OrderStatus.Выполняется)
           .Select(rec => new OrderViewModel
           {
               Id = rec.Id,
               ShipId = rec.ShipId,
               ClientId = rec.ClientId,
               ClientLogin = source.Clients.FirstOrDefault(cl =>
               cl.Id == rec.Id)?.Login,
               ImplementerId = rec.ImplementerId,
               ImplementerFIO = source.Implementers.FirstOrDefault(recC => 
               recC.Id == rec.ImplementerId)?.ImplementerFIO,
               ShipName = source.Ships.FirstOrDefault(mod =>
               mod.Id == rec.ShipId)?.ShipName,
               Count = rec.Count,
               Sum = rec.Sum,
               Status = rec.Status,
               DateCreate = rec.DateCreate,
               DateImplement = rec.DateImplement
           })
           .ToList();
        }
    }
}
