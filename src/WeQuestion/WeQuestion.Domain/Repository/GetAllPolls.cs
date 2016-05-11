using System.Collections.Generic;
using System.Linq;
using WeQuestion.Data;
using WeQuestion.Data.Entities;

namespace WeQuestion.Domain.Repository
{
    public class GetAllPolls
    {
        public IReadOnlyCollection<Poll> Get()
        {
            using (var dbContext = new WeQuestionDbContext())
            {
                return dbContext.Polls.ToList().Select(x => new Poll() {Title = x.Title, Id = x.Id}).ToList();
            }
        }
    }
}
