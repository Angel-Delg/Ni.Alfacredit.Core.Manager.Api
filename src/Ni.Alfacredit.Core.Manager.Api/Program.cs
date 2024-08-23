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

// Swagger Configuration
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(cfg => 
    {
        cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        cfg.RoutePrefix = "swagger/docs";
    });

    app.Use(async (context, next) =>
    {
        if (context.Request.Path.Equals("/swagger", StringComparison.OrdinalIgnoreCase) ||
            context.Request.Path.Equals("/swagger/docs/", StringComparison.OrdinalIgnoreCase))
        {
            context.Response.Redirect("/swagger/docs/index.html");
            return;
        }
        await next();
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();