using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Truestory.Middleware;
using Truestory.model;
using Truestory.model.pagination;
using Truestory.Repositories;
using Truestory.Repositories.implementations;
using Truestory.Services;
using Truestory.Services.Imlementations;
using Truestory.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGadgetService, GadgetService>();
builder.Services.AddScoped<IGadgetRepo, GadgetRepo>();
builder.Services.AddScoped<IValidator<Gadget>, GadgetValidator>();
builder.Services.AddScoped<IValidator<GadgetRequestParam>, FetchLaptopValidator>();
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

app.UseHttpsRedirection();
app.UseAuthorization();
////
///Custom exception handling
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

 

app.Run();
