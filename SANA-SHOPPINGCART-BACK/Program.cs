using Microsoft.EntityFrameworkCore;
using SANA_SHOPPINGCART_BACK.ApiHandlers;
using SANA_SHOPPINGCART_BACK.Infrastructure.DataSource;
using SANA_SHOPPINGCART_BACK.Infrastructure.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(config.GetConnectionString("sqlServer"),
        x => x.MigrationsAssembly("SANA-SHOPPINGCART-BACK.Infrastructure"));
});

builder.Services.AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(Assembly.Load("SANA-SHOPPINGCART-BACK.Application")));

builder.Services.AddDomainServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("/api/catalog").MapCatalog();
app.UseCors("AllowAnyOrigin");

app.Run();
