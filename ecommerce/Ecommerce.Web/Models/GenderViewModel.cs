using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Web.Models
{
    public class GenderViewModel
    {
        [Required]
        public string Name { get; set; }    
        [Required]
        public DateTime RecordDate { get; set; }    
        [Required]
        public bool RecordIsDeleted { get; set; }    
        [Required]
        public string RecordUserId { get; set; }    

    }
}