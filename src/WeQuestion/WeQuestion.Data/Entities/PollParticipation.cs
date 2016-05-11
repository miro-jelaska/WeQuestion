using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeQuestion.Data.Entities
{
    public class PollParticipation
    {
        [Key]
        public int Id { get; set; }

        public string Comment { get; set; }


        public virtual ICollection<UsersAnswer> UsersAnswers { get; set; }

        public virtual Poll Poll { get; set; }

        public virtual ProvisionalUser ProvisionalUser { get; set; }
    }
}
