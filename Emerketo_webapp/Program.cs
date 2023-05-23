using Emerketo_webapp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// SERVICE REGISTRATION
// Services can be registered to the DI-container on variable builder
// Services are simply all classes that can be used by the application

    // Adds the repository for accessing the products
builder.Services.AddScoped<IProductRepository, ProductRepository>();

    // Set up for MVC. Note that .AddMvc() is also available, but this is
    // deprecated and not recommended for use anymore.
builder.Services.AddControllersWithViews();


// Register DbContext

builder.Services.AddDbContext<EmerketoDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:EmerketoDbContextConnection"]);
});

var app = builder.Build();

// MIDDLEWARE
    // Middleware can be added to the variable app

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

    // for routing, should be places last. The default pattern is controller/action/id
app.MapDefaultControllerRoute();

// for seeding an empty database!
DbInitializer.Seed(app);

app.Run();
