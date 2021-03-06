﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L06.Input
{
    public class CreateReplyCmd
    {
        public String AuthorId { get; }
        public String QuestionId { get; }
        public String Reply { get; }

        public CreateReplyCmd(String authorId, String questionId, String reply)
        {
            AuthorId = authorId;
            QuestionId = questionId;
            Reply = reply;
        }
    }
}
