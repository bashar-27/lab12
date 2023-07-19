using lab12.Data;
using Microsoft.EntityFrameworkCore;

namespace lab12
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
           
            string conn = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services
                .AddDbContext<AsyncInnContext>
                (options =>options.UseSqlServer(conn));

            var app = builder.Build();
            app.MapControllers();
            app.MapGet("/", () => "Hello In My Application!");
            
            app.Run();
        }
    }
}