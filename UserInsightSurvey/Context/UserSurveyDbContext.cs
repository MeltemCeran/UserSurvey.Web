using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Data.EntityConfiguration;

namespace UserInsightSurvey.Context
{
	public class UserSurveyDbContext : IdentityDbContext<User>
	{
		public UserSurveyDbContext(DbContextOptions<UserSurveyDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new QuestionConfiguration());
			builder.ApplyConfiguration(new OptionConfiguration());
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<Option> Options { get; set; }
	}
}
