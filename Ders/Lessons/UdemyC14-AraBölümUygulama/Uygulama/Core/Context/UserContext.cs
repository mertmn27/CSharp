using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.DataAccessLayer;
using Uygulama.Entities;

namespace Uygulama.Core.Context
{
    internal class UserContext
    {
        public JsonRepository<User> Repository { get; set; }
        public UserContext()
        {
            Repository = new JsonRepository<User>("C:\\CustomerApp\\users.json");
        }
    }
}
