
using ProductManagement.MongoDatabase;
using ProductManagement.MongoDatabase.Models;
using WebAPI.Application.Attributes;
using WebAPI.Core.Attributes;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

DependencyApplicationServiceAttribute.AddDependecies(builder.Services);
DependencyCoreServiceAttribute.AddDependecies(builder.Services);

builder.Services.Configure<ProdutoDatabaseSettings>
    (builder.Configuration.GetSection("ProductManagementDatabase"));

builder.Services.AddSingleton<MongoContext>();

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
