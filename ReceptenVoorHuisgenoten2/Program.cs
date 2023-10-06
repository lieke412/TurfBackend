global using ReceptenVoorHuisgenoten2.Data;
global using Microsoft.EntityFrameworkCore;


namespace FreshHeadBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options => options.AddPolicy("AllowAllOrigins", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

            app.UseCors("AllowAllOrigins");
            app.UseCors("CorsPolicy");


            app.Run();

        }

        //private static void RegisterInterfaces(WebApplicationBuilder builder)
        //{
        //    builder.Services.AddScoped<IDealService, DealService>();
        //    builder.Services.AddScoped<IDealRepository, DealRepository>();
        //    builder.Services.AddScoped<ICompanyService, CompanyService>();
        //    builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        //}
    }
}