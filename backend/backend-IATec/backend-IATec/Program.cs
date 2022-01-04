using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using iatec.database;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

//var services = AddDbContext<ApplicationDBContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

app.UseSwagger();
app.MapGet("/cliente", () => new Cliente("Michael", "michaelcolla7@gmail.com"));
app.UseSwaggerUI();
app.Run();

public record Cliente(string Nome, string Email);

public class Veiculo
{
    private readonly IConfiguration Configuration;

    public TestModel(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDBContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
    }
    //public string Nome { get; set; } 
}

