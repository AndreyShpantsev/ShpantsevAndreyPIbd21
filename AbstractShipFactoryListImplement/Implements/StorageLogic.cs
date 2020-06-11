using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryListImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryListImplement.Implements
{
    public class StorageLogic : IStorageLogic
    {
        private readonly DataListSingleton source;
        public StorageLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<StorageViewModel> GetList()
        {
            List<StorageViewModel> result = new List<StorageViewModel>();
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                List<StorageDetailViewModel> StorageDetails = new
                List<StorageDetailViewModel>();
                for (int j = 0; j < source.StorageDetails.Count; ++j)
                {
                    if (source.StorageDetails[j].StorageId == source.Storages[i].Id)
                    {
                        string BilletName = string.Empty;
                        for (int k = 0; k < source.Details.Count; ++k)
                        {
                            if (source.StorageDetails[j].DetailId ==
                           source.Details[k].Id)
                            {
                                BilletName = source.Details[k].DetailName;
                                break;
                            }
                        }
                        StorageDetails.Add(new StorageDetailViewModel
                        {
                            Id = source.StorageDetails[j].Id,
                            StorageId = source.StorageDetails[j].StorageId,
                            DetailId = source.StorageDetails[j].DetailId,
                            DetailName = BilletName,
                            Count = source.StorageDetails[j].Count
                        });
                    }
                }
                result.Add(new StorageViewModel
                {
                    Id = source.Storages[i].Id,
                    StorageName = source.Storages[i].StorageName,
                    StorageDetails = StorageDetails
                });
            }
            return result;
        }
        public StorageViewModel GetElement(int id)
        {
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                List<StorageDetailViewModel> StorageDetails = new
                List<StorageDetailViewModel>();
                for (int j = 0; j < source.StorageDetails.Count; ++j)
                {
                    if (source.StorageDetails[j].StorageId == source.Storages[i].Id)
                    {
                        string DetailName = string.Empty;
                        for (int k = 0; k < source.Details.Count; ++k)
                        {
                            if (source.StorageDetails[j].DetailId ==
                           source.Details[k].Id)
                            {
                                DetailName = source.Details[k].DetailName;
                                break;
                            }
                        }
                        StorageDetails.Add(new StorageDetailViewModel
                        {
                            Id = source.StorageDetails[j].Id,
                            StorageId = source.StorageDetails[j].StorageId,
                            DetailId = source.StorageDetails[j].DetailId,
                            DetailName = DetailName,
                            Count = source.StorageDetails[j].Count
                        });
                    }
                }
                if (source.Storages[i].Id == id)
                {
                    return new StorageViewModel
                    {
                        Id = source.Storages[i].Id,
                        StorageName = source.Storages[i].StorageName,
                        StorageDetails = StorageDetails
                    };
                }
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(StorageBindingModel model)
        {
            int maxId = 0;
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id > maxId)
                {
                    maxId = source.Storages[i].Id;
                }
                if (source.Storages[i].StorageName == model.StorageName)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
            }
            source.Storages.Add(new Storage
            {
                Id = maxId + 1,
                StorageName = model.StorageName
            });
        }
        public void UpdElement(StorageBindingModel model)
        {
            int index = -1;
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id == model.Id)
                {
                    index = i;
                }
                if (source.Storages[i].StorageName == model.StorageName &&
                source.Storages[i].Id != model.Id)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
            }
            if (index == -1)
            {
                throw new Exception("Элемент не найден");
            }
            source.Storages[index].StorageName = model.StorageName;
        }
        public void DelElement(int id)
        {
            for (int i = 0; i < source.StorageDetails.Count; ++i)
            {
                if (source.StorageDetails[i].StorageId == id)
                {
                    source.StorageDetails.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id == id)
                {
                    source.Storages.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        public void FillStorage(StorageDetailBindingModel model)
        {
            int foundItemIndex = -1;
            for (int i = 0; i < source.StorageDetails.Count; ++i)
            {
                if (source.StorageDetails[i].DetailId == model.DetailId
                    && source.StorageDetails[i].StorageId == model.StorageId)
                {
                    foundItemIndex = i;
                    break;
                }
            }
            if (foundItemIndex != -1)
            {
                source.StorageDetails[foundItemIndex].Count =
                    source.StorageDetails[foundItemIndex].Count + model.Count;
            }
            else
            {
                int maxId = 0;
                for (int i = 0; i < source.StorageDetails.Count; ++i)
                {
                    if (source.StorageDetails[i].Id > maxId)
                    {
                        maxId = source.StorageDetails[i].Id;
                    }
                }
                source.StorageDetails.Add(new StorageDetail
                {
                    Id = maxId + 1,
                    StorageId = model.StorageId,
                    DetailId = model.DetailId,
                    Count = model.Count
                });
            }
        }
    }
}