using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama.Entities
{
    internal class Customer:BaseEntity
    {
        public string CompanyName { get; set; }
        public Guid UserID { get; set; }
    }
}
