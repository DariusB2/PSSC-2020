﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace L06.Input
{
    class SendAckToQOwnerCmd
    {
        [Required]
        public string ReplyId { get; }

        [Required]
        public string QuestionId { get; }

        [Required]
        public string Answer { get; }

        public SendAckToQOwnerCmd(string ReplyId, string QuestionId, string Answer)
        {
            ReplyId = this.ReplyId;
            QuestionId = this.QuestionId;
            Answer = this.Answer;
        }
    }
}
