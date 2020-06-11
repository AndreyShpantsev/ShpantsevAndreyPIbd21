using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryFileImplement.Models;
using AbstractShipFactoryBusinessLogic.BindingModels;
using System.Linq;

namespace AbstractShipFactoryFileImplement.Implements
{
    public class StorageLogic : IStorageLogic
    {
        private readonly ShipFactoryFileDataListSingleton source;
        public StorageLogic()
        {
            source = ShipFactoryFileDataListSingleton.GetInstance();
        }
        public List<StorageViewModel> GetList()
        {
            return source.Storages.Select(rec => new StorageViewModel
            {
                Id = rec.Id,
                StorageName = rec.StorageName,
                StorageDetails = source.StorageDetails.Where(z => z.StorageId == rec.Id).Select(x => new StorageDetailViewModel
                {
                    Id = x.Id,
                    StorageId = x.StorageId,
                    DetailId = x.DetailId,
                    DetailName = source.Details.FirstOrDefault(y => y.Id == x.DetailId)?.DetailName,
                    Count = x.Count
                }).ToList()
            })
                .ToList();
        }
        public StorageViewModel GetElement(int id)
        {
            var elem = source.Storages.FirstOrDefault(x => x.Id == id);
            if (elem == null)
            {
                throw new Exception("Элемент не найден");
            }
            else
            {
                return new StorageViewModel
                {
                    Id = id,
                    StorageName = elem.StorageName,
                    StorageDetails = source.StorageDetails.Where(z => z.StorageId == elem.Id).Select(x => new StorageDetailViewModel
                    {
                        Id = x.Id,
                        StorageId = x.StorageId,
                        DetailId = x.DetailId,
                        DetailName = source.Details.FirstOrDefault(y => y.Id == x.DetailId)?.DetailName,
                        Count = x.Count
                    }).ToList()
                };
            }
        }

        public void AddElement(StorageBindingModel model)
        {

            var elem = source.Storages.FirstOrDefault(x => x.StorageName == model.StorageName);
            if (elem != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            int maxId = source.Storages.Count > 0 ? source.Storages.Max(rec => rec.Id) : 0;
            source.Storages.Add(new Storage
            {
                Id = maxId + 1,
                StorageName = model.StorageName
            });
        }
        public void UpdElement(StorageBindingModel model)
        {
            var elem = source.Storages.FirstOrDefault(x => x.StorageName == model.StorageName && x.Id != model.Id);
            if (elem != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            var elemToUpdate = source.Storages.FirstOrDefault(x => x.Id == model.Id);
            if (elemToUpdate != null)
            {
                elemToUpdate.StorageName = model.StorageName;
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void DelElement(int id)
        {
            var elem = source.Storages.FirstOrDefault(x => x.Id == id);
            if (elem != null)
            {
                source.Storages.Remove(elem);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void FillStorage(StorageDetailBindingModel model)
        {
            var item = source.StorageDetails.FirstOrDefault(x => x.DetailId == model.DetailId
                    && x.StorageId == model.StorageId);

            if (item != null)
            {
                item.Count += model.Count;
            }
            else
            {
                int maxId = source.StorageDetails.Count > 0 ? source.StorageDetails.Max(rec => rec.Id) : 0;
                source.StorageDetails.Add(new StorageDetail
                {
                    Id = maxId + 1,
                    StorageId = model.StorageId,
                    DetailId = model.DetailId,
                    Count = model.Count
                });
            }
        }

        public bool CheckDetailsAvailability(int ShipId, int ShipsCount)
        {
            bool result = true;
            var ShipDetails = source.ShipDetails.Where(x => x.ShipId == ShipId);
            if (ShipDetails.Count() == 0) return false;
            foreach (var elem in ShipDetails)
            {
                int count = 0;
                var storageDetails = source.StorageDetails.FindAll(x => x.DetailId == elem.DetailId);
                count = storageDetails.Sum(x => x.Count);
                if (count < elem.Count * ShipsCount)
                    return false;
            }
            return result;
        }

        public void RemoveFromStorage(int ShipId, int ShipsCount)
        {
            var ShipDetails = source.ShipDetails.Where(x => x.ShipId == ShipId);
            if (ShipDetails.Count() == 0) return;
            foreach (var elem in ShipDetails)
            {
                int left = elem.Count * ShipsCount;
                var storageDetails = source.StorageDetails.FindAll(x => x.DetailId == elem.DetailId);
                foreach (var rec in storageDetails)
                {
                    int toRemove = left > rec.Count ? rec.Count : left;
                    rec.Count -= toRemove;
                    left -= toRemove;
                    if (left == 0) break;
                }
            }
            return;
        }
    }
}