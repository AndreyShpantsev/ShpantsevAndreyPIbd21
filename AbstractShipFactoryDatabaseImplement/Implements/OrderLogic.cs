using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Enums;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace AbstractShipFactoryDatabaseImplement.Implements
{
    public class OrderLogic : IOrderLogic
    {
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                Order element;
                if (model.Id.HasValue)
                {
                    element = context.Orders.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Order();
                    context.Orders.Add(element);
                }
                element.ShipId = model.ShipId == 0 ? element.ShipId : model.ShipId;
                element.ImplementerId = model.ImplementerId;
                element.ClientId = model.ClientId.Value;
                element.Count = model.Count;
                element.Sum = model.Sum;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                return context.Orders
                .Include(rec => rec.Ship)
                .Where(rec => model == null || rec.Id == model.Id
                || (model.DateFrom.HasValue && model.DateTo.HasValue
                && rec.DateCreate >= model.DateFrom.Value
                && rec.DateCreate <= model.DateTo.Value)
                || model.ClientId.HasValue && model.ClientId == rec.ClientId
                || model.FreeOrders.HasValue && model.FreeOrders.Value && !rec.ImplementerId.HasValue
                || model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId && rec.Status == OrderStatus.Выполняется)
                .Select(rec => new OrderViewModel
                {
                Id = rec.Id,
                ShipId = rec.ShipId,
                ImplementerId = rec.ImplementerId,
                ShipName = rec.Ship.ShipName,
                ClientId = rec.ClientId,
                ClientLogin = rec.Client.Login,
                Count = rec.Count,
                Sum = rec.Sum,
                Status = rec.Status,
                DateCreate = rec.DateCreate,
                DateImplement = rec.DateImplement,
                ImplementerFIO = rec.ImplementerId.HasValue ?
                rec.Implementer.ImplementerFIO : string.Empty
                })
            .ToList();
            }
        }
    }
}