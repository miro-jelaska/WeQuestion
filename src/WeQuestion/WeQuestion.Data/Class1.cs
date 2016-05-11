using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WeQuestion.Data
{
    public class WeQuestionDbContext : DbContext
    {
        public WeQuestionDbContext() :
            base(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=WeQuestion; Integrated Security = True; MultipleActiveResultSets=True")
        {
            var initializer = new CreateDatabaseIfNotExists<WeQuestionDbContext>();
            Database.SetInitializer(initializer);
        }

        public IDbSet<User> Users { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
