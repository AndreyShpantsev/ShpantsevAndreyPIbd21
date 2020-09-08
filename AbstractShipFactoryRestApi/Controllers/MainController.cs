using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.BusinessLogics;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using AbstractShipFactoryRestApi.Models;


namespace AbstractShipFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IShipLogic _ship;
        private readonly MainLogic _main;

        public MainController(IOrderLogic order, IShipLogic ship, MainLogic main)
        {
            _order = order;
            _ship = ship;
            _main = main;
        }

        [HttpGet]
        public List<Ship> GetShipList() => _ship.Read(null)?.Select(rec =>
        Convert(rec)).ToList();

        [HttpGet]
        public Ship GetShip(int shipId) =>
        Convert(_ship.Read(new ShipBindingModel
        { Id = shipId })?[0]);

        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) =>
        _order.Read(new OrderBindingModel
        { ClientId = clientId });

        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) =>
        _main.CreateOrder(model);

        private Ship Convert(ShipViewModel model)
        {
            if (model == null) return null;
            return new Ship
            {
                Id = model.Id,
                ShipName = model.ShipName,
                Price = model.Price
            };
        }
    }
}