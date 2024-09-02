using Microsoft.EntityFrameworkCore;
using ModernizationTask.Data;
using System.Transactions;

namespace ModernizationTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region context
            builder.Services.AddDbContext<ModernizationTaskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));
            #endregion

            #region repository
            //builder.Services.AddScoped<IRepository<int, Order>, OrderRepository>();
            #endregion

            #region service
            //builder.Services.AddScoped<IProductService, ProductService>();
            #endregion



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
