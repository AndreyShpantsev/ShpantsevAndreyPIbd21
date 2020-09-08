using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;
using AbstractShipFactoryBusinessLogic.Attributes;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ClientViewModel:BaseViewModel
    {
        [DataMember]
        [Column(title: "ФИО клиента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string FIO { get; set; }
        [Column(title: "Логин", width: 150)]
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "FIO",
            "Login"
        };
    }
}