using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Exceptions
{
    public class CoreCommonException : Exception
    {
        public string Error { get; set; }
        public string InvalidField { get; set; }
        public string[] MessageParams { get; set; } = new string[] { };

        public CoreCommonException(params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
        }

        public CoreCommonException(string invalidField = null) : base(string.Empty)
        {
            InvalidField = invalidField;
        }

        public CoreCommonException(string invalidField = null, params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public CoreCommonException(string message, string invalidField = null, params string[] messageParams) : base(message)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public CoreCommonException(string message, string invalidField = null) : base(message)
        {
            InvalidField = invalidField;
        }
    }
}
