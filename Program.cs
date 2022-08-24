
using Freebob;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .Enrich.WithProperty("Firma", "fir5")
    .WriteTo.Seq("http://localhost:5341")

    );

builder.Services.AddCors(options => options.AddPolicy("AllowAll",
    builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ConfigurationManager configuration = builder.Configuration;


builder.Services.AddScoped<CarServices>();
builder.Services.AddScoped<OperatorServices>();
builder.Services.AddScoped<OrderServices>();
builder.Services.AddScoped<PointServices>();
builder.Services.AddScoped<RequestServices>();
builder.Services.AddScoped<UserServices>();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("Db"));
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
