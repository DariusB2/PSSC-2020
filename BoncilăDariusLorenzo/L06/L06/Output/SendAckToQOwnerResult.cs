using System;
using System.Collections.Generic;
using System.Text;

namespace L06.Output
{
    public static partial class SendAckToQOwnerResult
    {
        public interface ISendAckToQOwnerResult { };
        public class ReplyReceived : ISendAckToQOwnerResult
        {
            public string Text { get; }
            public ReplyReceived(string text)
            {
                Text = text;
            }
        }
        public class InvalidReplyReceived : ISendAckToQOwnerResult
        {
            public string ErrorMessage { get; }
            public InvalidReplyReceived(string errormessage)
            {
                ErrorMessage = errormessage;
            }
        }
    }
}
