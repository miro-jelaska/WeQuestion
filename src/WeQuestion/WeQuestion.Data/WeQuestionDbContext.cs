using System.Data.Entity;
using WeQuestion.Data.Entities;

namespace WeQuestion.Data
{
    public class WeQuestionDbContext : DbContext
    {
        public WeQuestionDbContext()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=WeQuestion; Integrated Security = True; MultipleActiveResultSets=True")
        {
            var initializer = new DevelopmentDatabaseInitializer();
            Database.SetInitializer(initializer);
        }

        public IDbSet<ProvisionalUser> ProvisionalUsers { get; set; }
        public IDbSet<PollParticipation> PollParticipations { get; set; }
        public IDbSet<UsersAnswer> UsersAnswers { get; set; }
        public IDbSet<Poll> Polls { get; set; }
        public IDbSet<Question> Questions { get; set; }
        public IDbSet<AnswerOption> AnswerOptions { get; set; }


        public class DevelopmentDatabaseInitializer : DropCreateDatabaseIfModelChanges<WeQuestionDbContext>
        {
            public override void InitializeDatabase(WeQuestionDbContext context)
            {
                context.Database.CreateIfNotExists();
                // Prevents “Cannot drop database because it is currently in use” error.
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, $"ALTER DATABASE {context.Database.Connection.Database} SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                base.InitializeDatabase(context);
            }

            protected override void Seed(WeQuestionDbContext context)
            {
                var newPoll = new Poll()
                {
                    AccessToken = "CarTreePc",
                    IsOpen = false,
                    IsPublished = false,
                    Title = "Test poll"
                };
                context.Polls.Add(newPoll);

                context.SaveChanges();
            }
        }
    }
}
