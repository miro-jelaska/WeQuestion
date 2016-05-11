﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeQuestion.Data.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public virtual ICollection<AnswerOption> AnswerOptions { get; set; }
    }
}
