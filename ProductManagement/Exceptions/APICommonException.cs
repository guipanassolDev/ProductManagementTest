using System;

namespace WebAPI.Exceptions
{
    public class APICommonException : Exception
    {
        public string Error { get; set; }
        public string InvalidField { get; set; }
        public string[] MessageParams { get; set; } = new string[] { };

        public APICommonException(params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
        }

        public APICommonException(string invalidField = null) : base(string.Empty)
        {
            InvalidField = invalidField;
        }

        public APICommonException(string invalidField = null, params string[] messageParams) : base(string.Empty)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public APICommonException(string message, string invalidField = null, params string[] messageParams) : base(message)
        {
            MessageParams = messageParams;
            InvalidField = invalidField;
        }

        public APICommonException(string message, string invalidField = null) : base(message)
        {
            InvalidField = invalidField;
        }
    }
}
