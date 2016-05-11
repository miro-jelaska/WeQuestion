﻿using System.ComponentModel.DataAnnotations;

namespace WeQuestion.Data.Entities
{
    public class AnswerOption
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }
    }
}
