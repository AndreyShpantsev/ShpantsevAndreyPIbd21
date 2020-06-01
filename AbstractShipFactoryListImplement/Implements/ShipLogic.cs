using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryListImplement.Models;

namespace AbstractShipFactoryListImplement.Implements
{
    public class ShipLogic : IShipLogic
    {
        private readonly DataListSingleton source;
        public ShipLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(ShipBindingModel model)
        {
            Ship tempShip = model.Id.HasValue ? null : new Ship { Id = 1 };
            foreach (var ship in source.Ships)
            {
                if (ship.ShipName == model.ShipName && ship.Id != model.Id)
                {
                    throw new Exception("Уже есть судно с таким названием");
                }
                if (!model.Id.HasValue && ship.Id >= tempShip.Id)
                {
                    tempShip.Id = ship.Id + 1;
                }
                else if (model.Id.HasValue && ship.Id == model.Id)
                {
                    tempShip = ship;
                }
            }
            if (model.Id.HasValue)
            {
                if (tempShip == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempShip);
            }
            else
            {
                source.Ships.Add(CreateModel(model, tempShip));
            }
        }
        public void Delete(ShipBindingModel model)
        {
            for (int i = 0; i < source.ShipDetails.Count; ++i)
            {
                if (source.ShipDetails[i].ShipId == model.Id)
                {
                    source.ShipDetails.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.Ships.Count; ++i)
            {
                if (source.Ships[i].Id == model.Id)
                {
                    source.Ships.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Судно не найдено");
        }
        private Ship CreateModel(ShipBindingModel model, Ship ship)
        {
            ship.ShipName = model.ShipName;
            ship.Price = model.Price;
            int maxPCId = 0;
            for (int i = 0; i < source.ShipDetails.Count; ++i)
            {
                if (source.ShipDetails[i].Id > maxPCId)
                {
                    maxPCId = source.ShipDetails[i].Id;
                }
                if (source.ShipDetails[i].ShipId == ship.Id)
                {
                    if
                    (model.ShipDetails.ContainsKey(source.ShipDetails[i].DetailId))
                    {
                        source.ShipDetails[i].Count =
                        model.ShipDetails[source.ShipDetails[i].DetailId].Item2;                   
                        model.ShipDetails.Remove(source.ShipDetails[i].DetailId);
                    }
                    else
                    {
                        source.ShipDetails.RemoveAt(i--);
                     }
                }
            }

            foreach (var pc in model.ShipDetails)
            {
                source.ShipDetails.Add(new ShipDetail
                {
                    Id = ++maxPCId,
                    ShipId = ship.Id,
                    DetailId = pc.Key,
                    Count = pc.Value.Item2
                });
            }
            return ship;
        }
        public List<ShipViewModel> Read(ShipBindingModel model)
        {
            List<ShipViewModel> result = new List<ShipViewModel>();
            foreach (var component in source.Ships)
            {
                if (model != null)
                {
                    if (component.Id == model.Id)
                    {
                        result.Add(CreateViewModel(component));
                        break;
                    }
                    continue;
                }
                result.Add(CreateViewModel(component));
            }
            return result;
        }
        private ShipViewModel CreateViewModel(Ship ship)
        {
            Dictionary<int, (string, int)> shipComponents = new Dictionary<int,
                (string, int)>();
            foreach (var pc in source.ShipDetails)
            {
                if (pc.ShipId == ship.Id)
                {
                    string componentName = string.Empty;
                    foreach (var component in source.Details)
                    {
                        if (pc.DetailId == component.Id)
                        {
                            componentName = component.DetailName;
                            break;
                        }
                    }
                    shipComponents.Add(pc.DetailId, (componentName, pc.Count));
                }
            }
            return new ShipViewModel
            {
                Id = ship.Id,
                ShipName = ship.ShipName,
                Price = ship.Price,
                ShipDetails = shipComponents
            };
        }
    }
}
