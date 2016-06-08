using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DB
{
    public class Company
    {
        [Key()]
        public int ID { get; set; }
        [StringLength(50)]
        [Required()]
        [DisplayName("Название:")]
        public string Name { get; set; }
       


    }
}
