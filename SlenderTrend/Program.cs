using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Repositories;
using Services.DataServices;

namespace SlenderTrend {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("Postgres");

            builder.Services.AddDbContext<SlenderTrendContext>(e => e.UseNpgsql(connectionString));

            builder.Services.AddScoped<DurationRepository>();
            builder.Services.AddScoped<RatingRepository>();
            builder.Services.AddScoped<ResponseTimeRepository>();
            builder.Services.AddScoped<TagRepository>();
            builder.Services.AddScoped<TotalChatRepository>();

            builder.Services.AddScoped<DurationDataService>();
            builder.Services.AddScoped<RatingDataService>();
            builder.Services.AddScoped<ResponseTimeDataService>();
            builder.Services.AddScoped<TagDataService>();
            builder.Services.AddScoped<TotalChatDataService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(builder =>
                builder
                .WithOrigins("*")
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
