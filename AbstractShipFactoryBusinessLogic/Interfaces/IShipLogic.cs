using System;
using System.Collections.Generic;
using System.Text;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryBusinessLogic.Interfaces
{
    public interface IShipLogic
    {
        List<ShipViewModel> Read(ShipBindingModel model);

        void CreateOrUpdate(ShipBindingModel model);

        void Delete(ShipBindingModel model);
    }
}
