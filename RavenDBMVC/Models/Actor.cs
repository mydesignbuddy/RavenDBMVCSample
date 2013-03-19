using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDBMVC.Models
{
    public class Actor
    {
        public string Name { get; set;}
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
    }
}