using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Name size is exceeding than 20.")]
        public string Name { get; set; }

        [MaxLength(12)]
        public string Mobile { get; set; }

        [StringLength(15, ErrorMessage = "Address size is exceeding than 15.")]
        public string Address { get; set; }
    }
}