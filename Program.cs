using PizzaParty.DB;
using PizzaParty.Middlewares;
using PizzaParty.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PostgresContext>();
builder.Services.AddScoped<PizzaService>();
builder.Services.AddTransient<HttpResponseErrorMiddeware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<HttpResponseErrorMiddeware>();

app.MapControllers();

app.Run();
