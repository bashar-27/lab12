using lab12.Data;
using lab12.Models.Interfaces;
using lab12.Models.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
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

            builder.Services.AddTransient<IHotel,HotelService>();
            builder.Services.AddTransient<IRoom, RoomService>();
            builder.Services.AddTransient<IAmenities, AmenitiesService>();

            var app = builder.Build();
            app.MapControllers();
            app.MapGet("/", () => "Hello In My Application!");
            
            app.Run();
        }
    }
}