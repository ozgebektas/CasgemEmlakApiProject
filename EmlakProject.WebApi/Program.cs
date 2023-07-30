using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.DataAccessLayer.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.Configure<DbSetting>(builder.Configuration.GetSection("DbSettings"));
//builder.Services.AddSingleton<IDbSetting>(x => x.GetRequiredService<IOptions<DbSetting>>().Value);
//builder.Services.AddSingleton<IMongoClient>(m => new MongoClient(builder.Configuration.GetValue<string>("DbSettings:ConnectionString")));

builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();
builder.Services.AddScoped<IPropertyService, PropertyManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IAdminService, AdminManager>();
// Add services to the container.

builder.Services.AddControllers();
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

app.Run();
