using DAL;
using Microsoft.EntityFrameworkCore;
using Services.Implementations;
using Services.Interfacces;
using Services.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<IPruebaDBContext, PruebaDBContext>(
    options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("default"), b => b.MigrationsAssembly(nameof(WebApplication1)))
    );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ProductMappings));

builder.Services.AddScoped<IProductsService, ProductsService>();

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
