using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    public struct CreateQuestionCmd
    {
        [Required]
        [MaxLength(1000)]
        public string Title { get; private set; }
        [Required]
        public string Body { get; private set; }
        [Required]
        public string[] Tags { get; private set; }
        [Required]
        public int Votes { get; private set; }

        public CreateQuestionCmd(string Title, string Body, string[] Tags, int Votes)
        {
            this.Title = Title;
            this.Body = Body;
            this.Tags = Tags;
            this.Votes = Votes;
        }
    }
}
