using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractShipFactoryDatabaseImplement.Implements
{
    public class ShipLogic : IShipLogic
    {
        public void CreateOrUpdate(ShipBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Ship element = context.Ships.FirstOrDefault(rec =>
                       rec.ShipName == model.ShipName && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть судно с таким названием");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.Ships.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new Ship();
                            context.Ships.Add(element);
                        }
                        element.ShipName = model.ShipName;
                        element.Price = model.Price;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var productComponents = context.ShipDetails.Where(rec
                           => rec.ShipId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.ShipDetails.RemoveRange(productComponents.Where(rec =>
                            !model.ShipDetails.ContainsKey(rec.DetailId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateComponent in productComponents)
                            {
                                updateComponent.Count =
                               model.ShipDetails[updateComponent.DetailId].Item2;

                                model.ShipDetails.Remove(updateComponent.DetailId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var pc in model.ShipDetails)
                        {
                            context.ShipDetails.Add(new ShipDetail
                            {
                                ShipId = element.Id,
                                DetailId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(ShipBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // удаяем записи по компонентам при удалении изделия
                        context.ShipDetails.RemoveRange(context.ShipDetails.Where(rec =>
                        rec.ShipId == model.Id));
                        Ship element = context.Ships.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element != null)
                        {
                            context.Ships.Remove(element);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<ShipViewModel> Read(ShipBindingModel model)
        {
            using (var context = new AbstractShipFactoryDatabase())
            {
                return context.Ships
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new ShipViewModel
               {
                   Id = rec.Id,
                   ShipName = rec.ShipName,
                   Price = rec.Price,
                   ShipDetails = context.ShipDetails
                .Include(recPC => recPC.Detail)
               .Where(recPC => recPC.ShipId == rec.Id)
               .ToDictionary(recPC => recPC.DetailId, recPC =>
                (recPC.Detail?.DetailName, recPC.Count))
               })
               .ToList();
            }
        }
    }
}