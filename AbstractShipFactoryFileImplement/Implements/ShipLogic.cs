using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AbstractShipFactoryFileImplement.Implements
{
    public class ShipLogic : IShipLogic
    {
        private readonly ShipFactoryFileDataListSingleton source;
        public ShipLogic()
        {
            source = ShipFactoryFileDataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(ShipBindingModel model)
        {
            Ship element = source.Ships.FirstOrDefault(rec => rec.ShipName ==
           model.ShipName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть судно с таким названием");
            }
            if (model.Id.HasValue)
            {
                element = source.Ships.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Судно не найдено");
                }
            }
            else
            {
                int maxId = source.Ships.Count > 0 ? source.Ships.Max(rec =>
               rec.Id) : 0;
                element = new Ship { Id = maxId + 1 };
                source.Ships.Add(element);
            }
            element.ShipName = model.ShipName;
            element.Price = model.Price;
            // удалили те, которых нет в модели
            source.ShipDetails.RemoveAll(rec => rec.ShipId == model.Id &&
           !model.ShipDetails.ContainsKey(rec.DetailId));
            // обновили количество у существующих записей
            var updateDetails = source.ShipDetails.Where(rec => rec.ShipId ==
           model.Id && model.ShipDetails.ContainsKey(rec.DetailId));
            foreach (var updateDetail in updateDetails)
            {
                updateDetail.Count =
                model.ShipDetails[updateDetail.DetailId].Item2;
                model.ShipDetails.Remove(updateDetail.DetailId);
            }
            // добавили новые
            int maxPCId = source.ShipDetails.Count > 0 ?
           source.ShipDetails.Max(rec => rec.Id) : 0;
            foreach (var sd in model.ShipDetails)
            {
                source.ShipDetails.Add(new ShipDetail
                {
                    Id = ++maxPCId,
                    ShipId = element.Id,
                    DetailId = sd.Key,
                    Count = sd.Value.Item2
                });
            }
        }
        public void Delete(ShipBindingModel model)
        {
            // удаяем записи по компонентам при удалении изделия
            source.ShipDetails.RemoveAll(rec => rec.ShipId == model.Id);
            Ship element = source.Ships.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Ships.Remove(element);
            }
            else
            {
                throw new Exception("Судно не найдено");
            }
        }
        public List<ShipViewModel> Read(ShipBindingModel model)
        {
            return source.Ships
            .Where(rec => model == null || rec.Id == model.Id)
            .Select(rec => new ShipViewModel
            {
                Id = rec.Id,
                ShipName = rec.ShipName,
                Price = rec.Price,
                ShipDetails = source.ShipDetails
            .Where(recPC => recPC.ShipId == rec.Id)
            .ToDictionary(recPC => recPC.DetailId, recPC =>
            (source.Details.FirstOrDefault(recC => recC.Id ==
           recPC.DetailId)?.DetailName, recPC.Count))
            })
            .ToList();
        }
    }
}
