using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryBusinessLogic.Interfaces
{
    public interface IDetailLogic
    {
        List<DetailViewModel> Read(DetailBindingModel model);

        void CreateOrUpdate(DetailBindingModel model);

        void Delete(DetailBindingModel model);
    }
}
