using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class MessageAddViewModel
    {
        [Required]
        public string ToUser { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Details { get; set; }
    }
}
