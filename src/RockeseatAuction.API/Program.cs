using System.Security.Cryptography.Xml;
using Microsoft.OpenApi.Models;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.DataAccess;
using RockeseatAuction.API.Filters;
using RockeseatAuction.API.Services;
using RockeseatAuction.API.UseCases.Auctions.Offers.CreateOffer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = @"Jwt Authorization header using the Bearer scheme.
        Enter 'Bearer' [space] and then your token in the input below.
        Example: 'Bearer 12345dasfsf'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            },
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header
        },
        new List<string>()
        }

    });
});

builder.Services.AddScoped<AuthenticationUserAttribute>();
builder.Services.AddScoped<LoggedUser>();
builder.Services.AddScoped<CreateOfferUseCase>();
builder.Services.AddScoped<IAuctionRepository, AuctionRepository>();

builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthentication();
app.Run();

