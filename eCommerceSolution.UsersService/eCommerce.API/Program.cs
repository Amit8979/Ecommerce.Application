using eCommerce.Core;
using eCommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddInfrastructure();
builder.Services.AddCoreService();

// Add controllers
builder.Services.AddControllers();
var app = builder.Build();

// Routing.
app.UseRouting();

// Auth
app.UseAuthentication();
app.UseAuthorization();

// Controller Routes.
app.MapControllers();

app.Run();
