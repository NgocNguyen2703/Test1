using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Test1.Models
{	
[Table("CompanyNTN535s")]

    public class CompanyNTN535
    {
        [Key]
        [StringLength(20)]
        public string CompanyId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string CompanyName { get; set; }
    }
}