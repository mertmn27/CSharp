using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama.Entities
{
    internal class BaseEntity
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
