using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RavenDBMVC.Models;

namespace RavenDBMVC.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public IList<Actor> Actors { get; set; }
    }
}