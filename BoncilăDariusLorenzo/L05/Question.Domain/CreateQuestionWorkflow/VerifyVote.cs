using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.Votes;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class VerifyVote
    {
        public Result<VerifiedVotes> VerifiyVotes(InvalidNumberVotes votes)
        {
            return new VerifiedVotes(votes);
        }
    }
}
