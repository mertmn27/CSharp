using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama.Entities
{
    internal class CallHistory:BaseEntity
    {
        public Guid CompanyID { get; set; }
        public Guid UserID { get; set; }
        public string CallType { get; set; }
        public string CallValue { get; set; }
        public string CallNote { get; set; }
    }
}
