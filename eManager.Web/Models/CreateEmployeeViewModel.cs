using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public virtual int DepartmentId { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime HireDate { get; set; }
    }
}