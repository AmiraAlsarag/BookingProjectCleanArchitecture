using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using BookingProject.Infrastructure.Repositories;
using BookingProject.Infrastructure;
using BookingProject.Service;
using BookingProject.Core;
using BookingProject.Core.MiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//ADD CONNECTION TO SQL
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});

#region Dependency Injection


builder.Services.AddInfrastructureDependecies()
				.AddServiceDependecies()
				.AddCoreDependecies();
#endregion

#region AllowCORS
var CORS = "_cors";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: CORS,
					  policy =>
					  {
						  policy.AllowAnyHeader();
						  policy.AllowAnyMethod();
						  policy.AllowAnyOrigin();
					  });
});
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseCors(CORS);

app.UseAuthorization();

app.MapControllers();

app.Run();
