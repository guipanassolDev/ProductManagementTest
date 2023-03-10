using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Exceptions
{
    public class ApplicationCommonException : Exception
    {
        public string Error { get; set; }
        public string InvalidField { get; set; }
        public string[] MessageParams { get; set; } = new string[] { };

        public ApplicationCommonException(params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
        }

        public ApplicationCommonException(string invalidField = null) : base(string.Empty)
        {
            InvalidField = invalidField;
        }

        public ApplicationCommonException(string invalidField = null, params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public ApplicationCommonException(string message, string invalidField = null, params string[] messageParams) : base(message)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public ApplicationCommonException(string message, string invalidField = null) : base(message)
        {
            InvalidField = invalidField;
        }
    }
}
