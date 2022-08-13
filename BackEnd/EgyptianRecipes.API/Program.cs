using EgyptianRecipes.Application;
using EgyptianRecipes.Infrastructure;
using EgyptianRecipes.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddNewtonsoftJson(options =>
//                   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

PersistenceServiceRegistration.AddPersistenceServices(builder.Services, builder.Configuration);
InfrastructureServiceRegistration.AddInfrastructureServices(builder.Services, builder.Configuration);
ApplicationServiceRegistration.AddApplicationServices(builder.Services);

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
