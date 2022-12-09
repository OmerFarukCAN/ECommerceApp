using ECommerce.Application.Validators.Products;
using ECommerce.Infrastructure.Filters;
using ECommerce.Persistence;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace ECommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddPersistenceServices();

            builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy
                .WithOrigins("https://localhost:4200", "https://localhost:4200/", "http://localhost:4200", "http://localhost:4200/")
                .AllowAnyHeader()
            .AllowAnyMethod()
            ));

            builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateProductValidar>();
            builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
                .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true); // Default filters off

            //builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
            //    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidar>())
            //    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true); // Default filters off

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

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}