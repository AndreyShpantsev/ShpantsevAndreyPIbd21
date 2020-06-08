using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryBusinessLogic.Interfaces
{
    public interface IImplementerLogic
    {
        List<ImplementerViewModel> Read(ImplementerBindingModel model);
        void CreateOrUpdate(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);
    }
}
