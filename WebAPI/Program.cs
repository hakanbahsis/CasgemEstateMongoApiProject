using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Mongo;
using DataAccess.Repository;
using DataAccess.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<MongoSettings>(options =>
{
    options.ConnectionString = builder.Configuration.GetSection("MongoConnection:ConnectionString").Value;
    options.Database = builder.Configuration.GetSection("MongoConnection:Database").Value;
});
builder.Services.AddScoped(typeof(IRepository<>), typeof(MongoRepositoryBase<>));
builder.Services.AddScoped<IEstateService, EstateManager>();
builder.Services.AddScoped<IEstateDal, MongoEstateDal>();

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
