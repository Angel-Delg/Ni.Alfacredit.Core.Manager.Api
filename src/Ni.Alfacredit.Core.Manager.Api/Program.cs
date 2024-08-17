using Ni.Alfacredit.Core.Manager.Api.Application;
using Ni.Alfacredit.Core.Manager.Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddApplicationServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(cfg => 
    {
        cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "Alfacredit-Core-Manager-Api");
        cfg.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();