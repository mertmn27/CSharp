using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.DataAccessLayer;
using Uygulama.Entities;

namespace Uygulama.Core.Context
{
    internal class CustomerContext
    {
        public JsonRepository<Customer> Repository { get; set; }
        public CustomerContext()
        {
            Repository = new JsonRepository<Customer>("C:\\CustomerApp\\customers.json");
        }
    }
}
