using FreddysSurfShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Services before builder.Build();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();

builder.Services.AddScoped<ISurfboardRepository, MockSurfboardRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware components after the build but before app.Run(;
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
