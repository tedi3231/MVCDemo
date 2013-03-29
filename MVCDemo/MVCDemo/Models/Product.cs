using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Product
    {
        public Guid Id { set; get; }

        [Display(Name="产品名称")]
        public string Name { set; get; }
    }
}