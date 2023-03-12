using FlightFinder.Data;
using FlightFinder.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFlightRepository, FlightRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services
    .AddDbContext<FlightsContext>(option =>
    {
        option.UseSqlServer("Server=localhost, 1433;Database=FlightBooking;User Id=sa;Password=Stockholm-9876;TrustServerCertificate=True;");
        option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    });
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