using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class WriterInfoViewModel
    {
        public string namesurname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public IFormFile image { get; set; }

        public string password { get; set; }
    }
}
