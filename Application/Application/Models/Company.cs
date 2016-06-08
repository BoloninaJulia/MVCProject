using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Company
    {
        [DisplayName("Компания")]
        public string Name { get; set; }
        public int ID { get; set; }

    }
}