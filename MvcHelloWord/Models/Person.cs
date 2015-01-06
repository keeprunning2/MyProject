using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHelloWord.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Gender { get; set; }
    }
}