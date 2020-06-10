using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AbstractShipFactoryFileImplement.Implements
{
    public class DetailLogic : IDetailLogic
    {
        private readonly ShipFactoryFileDataListSingleton source;
        public DetailLogic()
        {
            source = ShipFactoryFileDataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(DetailBindingModel model)
        {
            Detail element = source.Details.FirstOrDefault(rec => rec.DetailName
           == model.DetailName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть деталь с таким названием");
            }
            if (model.Id.HasValue)
            {
                element = source.Details.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Деталь не найдена");
                }
            }
            else
            {
                int maxId = source.Details.Count > 0 ? source.Details.Max(rec =>
               rec.Id) : 0;
                element = new Detail { Id = maxId + 1 };
                source.Details.Add(element);
            }
            element.DetailName = model.DetailName;
        }
        public void Delete(DetailBindingModel model)
        {
            Detail element = source.Details.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                source.Details.Remove(element);
            }
            else
            {
                throw new Exception("Деталь не найдена");
            }
        }
        public List<DetailViewModel> Read(DetailBindingModel model)
        {
            return source.Details
            .Where(rec => model == null || rec.Id == model.Id)
            .Select(rec => new DetailViewModel
            {
                Id = rec.Id,
                DetailName = rec.DetailName
            })
            .ToList();
        }
    }
}
