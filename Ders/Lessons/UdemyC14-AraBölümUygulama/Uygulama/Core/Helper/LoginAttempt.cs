using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama.Core.Helper
{
    internal static class LoginAttempt
    {
        public static Dictionary<string, int> FailedCounts;

        static LoginAttempt()
        {
            FailedCounts = new Dictionary<string, int>();
        }
    }
}
