using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama.Entities
{
    internal class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLock { get; set; }
        public DateTime LockDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
