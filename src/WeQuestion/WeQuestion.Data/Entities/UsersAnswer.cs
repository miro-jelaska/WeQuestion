using System.ComponentModel.DataAnnotations;

namespace WeQuestion.Data.Entities
{
    public class UsersAnswer
    {
        [Key]
        public int Id { get; set; }

        public int AnswerId { get; set; }

        public virtual Question Question { get; set; }

        public virtual PollParticipation PollParticipation { get; set; }
    }
}
