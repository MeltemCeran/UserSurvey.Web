using Microsoft.EntityFrameworkCore;
using System;
using UserInsightSurvey.Context;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Managers.Concrete;
using UserInsightSurvey.Repositories.Abstract;
using UserInsightSurvey.Repositories.Concrete;

namespace UserInsightSurvey
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<UserSurveyDbContext>(options =>
	        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			builder.Services.AddDefaultIdentity<User>(options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequiredLength = 6;
			})
			.AddEntityFrameworkStores<UserSurveyDbContext>();

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<IUserRegisterManager, UserRegisterManager>();
			builder.Services.AddScoped<ISurveyManager, SurveyManager>();
			builder.Services.AddScoped<IUserRepository, UserRepository>();
			builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
			builder.Services.AddScoped<IOptionRepository, OptionRepository>();
			builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Register}/{id?}");

            app.Run();
        }
    }
}
