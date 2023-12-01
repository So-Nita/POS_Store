using Microsoft.EntityFrameworkCore;
using POSLibrary.DataContexts;
using POSLibrary.Interface;
using POSLibrary.Interface.Category;
using POSLibrary.Interface.Product;
using POSLibrary.Interface.SellOrder;
using POSLibrary.Models;
using POSLibrary.Repository;
using POSLibrary.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<PosContext>(opt =>
{
    opt.UseMySql(connectionStrings, ServerVersion.AutoDetect(connectionStrings));
}, ServiceLifetime.Transient);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISellOrderService, SellOrderService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped<IRepository<ProductByCategory>, Repository<ProductByCategory>>();  

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
