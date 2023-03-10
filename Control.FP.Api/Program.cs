using Control.FP.Api.Repositories;
using Control.FP.Api.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IProductCategoryRepository, InMemoryProductControllerRepository>();
builder.Services.AddSingleton<IUsuarioDescriptionRepository, InMemoryUsuarioControllerRepository>();
builder.Services.AddSingleton<IIngresoDescriptionRepository, InMemoryIngresoControllerRepository>();
builder.Services.AddSingleton<IGastoDescriptionRepository, InMemoryGastoControllerRepository>();
builder.Services.AddSingleton<IDireccionDescriptionRepository, InMemoryDireccionControllerRepository>();

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