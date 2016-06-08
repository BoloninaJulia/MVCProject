using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Info
    {
       
        [DisplayName("Компания")]
        public string Name { get; set; }
        [DisplayName("Пользователь")]
        public string User { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
    }
}