﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationCRUD.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        
        [Required]
        public string MobileNo { get; set; }
    }
}