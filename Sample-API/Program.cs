using AutoMapper;
using Sample_API.Infraestructure.Repository;
using Sample_API.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMarvelService, MarvelService>();
builder.Services.AddScoped<IMarvelRepository, MarvelRepository>();

builder.Services.AddHttpClient();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AllowNullCollections = true;
    mc.AddProfile(new Sample_API.Infraestructure.MarvelMapper());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
