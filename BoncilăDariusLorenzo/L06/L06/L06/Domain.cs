using System;
using System.Collections.Generic;
using System.Text;
using Access.Primitives.IO;
using static PortExt;
using L06.Output;
using L06.Input;

namespace L06
{
    class Domain
    {
        public static Port<CreateReplyResult.ICreateReplyResult> ValidateReply(string questionId, string userId, string answer)
            => NewPort<CreateReplyCmd, CreateReplyResult.ICreateReplyResult>(new CreateReplyCmd(userId, questionId, answer));

        public static Port<CheckLanguageResult.ICheckLanguageResult> CheckLanguage(string text)
            => NewPort<CheckLanguageCmd, CheckLanguageResult.ICheckLanguageResult>(new CheckLanguageCmd(text));

        public static Port<SendAckToQOwnerResult.ISendAckToQOwnerResult> SendAckToQOwner(string replyid, string questionid, string answer)
       => NewPort<SendAckToQOwnerCmd, SendAckToQOwnerResult.ISendAckToQOwnerResult>(new SendAckToQOwnerCmd(replyid, questionid, answer));

        public static Port<SendAckToReplyAuthorResult.ISendAskToReplyAuthorResult> SendAckToReplyAuthor(string replyid, string questionid, string answer)
        => NewPort<SendAckToReplyAuthorCmd, SendAckToReplyAuthorResult.ISendAskToReplyAuthorResult>(new SendAckToReplyAuthorCmd(replyid, questionid, answer));

    }
}
