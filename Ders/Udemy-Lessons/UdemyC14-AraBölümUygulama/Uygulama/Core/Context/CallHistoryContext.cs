using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.DataAccessLayer;
using Uygulama.Entities;

namespace Uygulama.Core.Context
{
    internal class CallHistoryContext
    {
        public JsonRepository<CallHistory> Repository { get; set; }
        public CallHistoryContext()
        {
            Repository = new JsonRepository<CallHistory>("C:\\CustomerApp\\callhistory.json");
        }
    }
}
