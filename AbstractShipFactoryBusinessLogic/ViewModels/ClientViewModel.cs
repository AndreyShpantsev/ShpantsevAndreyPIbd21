using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace AbstractShipFactoryBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Ф.И.О.")]
        public string FIO { get; set; }
        [DataMember]
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
