using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DB
{
    public class User
    {
        [Key()]
        public int ID { get; set; }
        [StringLength(50)]
        [Required()]
        [DisplayName("ФИО:")]
        public string Name { get; set; }
        [StringLength(10)]
        [Required()]
        [DisplayName("Логин:")]
        public string Login { get; set; }
        [StringLength(16)]
        [Required()]
        [DisplayName("Пароль:")]
        public string Password{ get; set; }
        [DisplayName("ID Компании:")]
        public int IDCompany { get; set; }
        [StringLength(20)]
        [Required()]
        [DisplayName("Статус контракта:")]
        public string StatusContract { get; set; }

    }
}

