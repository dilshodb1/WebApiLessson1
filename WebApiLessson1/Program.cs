
using Microsoft.EntityFrameworkCore;
using WebApiLessson1.Persistence;

namespace WebApiLessson1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            Console.WriteLine(builder.Configuration.GetConnectionString("AppContext"));
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("AppContext"));
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
