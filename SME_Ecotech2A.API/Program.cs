using SME_Ecotech2A.Api;
using SME_Ecotech2A.Api.Middleware;
using SME_Ecotech2A.Application;
using SME_Ecotech2A.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services
    .AddApi(builder.Configuration)
    .AddApplication()
    .AddInfrastructure();
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
// Use global exception middleware before other middleware
app.UseMiddleware<GlobalExceptionMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
