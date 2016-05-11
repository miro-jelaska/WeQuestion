using System;
using System.ComponentModel.DataAnnotations;

namespace WeQuestion.Data.Entities
{
    public class ProvisionalUser
    {
        [Key]
        public Guid Id { get; set; }
    }
}
