using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion
{
    public struct CreateQuestionCommand
    {
        public CreateQuestionCommand(int questionId, string title, string body, string tags)
        {
            QuestionId = questionId;
            Title = title;
            Body = body;
            Tags = tags;
        }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Tags { get; set; }
    }
}
