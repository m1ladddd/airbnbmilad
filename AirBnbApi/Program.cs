// Milad Husseini.
// S1172436

using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using AirBnbApi.Data;
using AirBnbApi.Repositories;
using AirBnbApi.Services;
using Microsoft.Extensions.Options;
using System.Reflection;
using Asp.Versioning;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using AirBnbApi;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("https://localhost:7279");

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<AirBnbDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirBnbDbContext") ?? throw new InvalidOperationException("Connection string 'AirBnbDbContext' not found.")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
}).AddMvc().AddApiExplorer();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
builder.Services.AddSwaggerGen(c =>
{
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    c.OperationFilter<SwaggerDefaultValues>();
});

builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IAirBnbRepository, AirBnbRepository>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        foreach (var description in app.DescribeApiVersions())
        {
            c.SwaggerEndpoint(
                $"/swagger/{description.GroupName}/swagger.json",
                description.GroupName);
        }
    });
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapGet("/", (HttpContext context) => context.Response.Redirect("/swagger"));

app.MapControllers();

app.Run();
