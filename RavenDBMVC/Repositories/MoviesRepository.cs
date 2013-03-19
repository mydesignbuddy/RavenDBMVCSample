using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client.Embedded;

namespace RavenDBMVC.Repositories
{
    public class MoviesRepository
    {
        private EmbeddableDocumentStore DocumentStore { get; set; }

        public MoviesRepository()
        {
            DocumentStore = new EmbeddableDocumentStore { DataDirectory = "~/data" };
            DocumentStore.Initialize();
        }

        public Create()
        {
            
        }
    }
}