using LifetimeDemo.Implementations;
using LifetimeDemo.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Add Transient Service
//builder.Services.AddTransient<ICounter, Counter>();
//builder.Services.AddTransient<IFirstInstanace, FirstInstance>();
//builder.Services.AddTransient<ISecondInstance, SecondInstance>();

//Add Scoped Service
//builder.Services.AddScoped<ICounter, Counter>();
//builder.Services.AddTransient<IFirstInstanace, FirstInstance>();
//builder.Services.AddTransient<ISecondInstance, SecondInstance>();

//Add Singleton Service
builder.Services.AddSingleton<ICounter, Counter>();
builder.Services.AddTransient<IFirstInstanace, FirstInstance>();
builder.Services.AddTransient<ISecondInstance, SecondInstance>();



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

app.UseAuthorization();

app.MapControllers();

app.Run();
