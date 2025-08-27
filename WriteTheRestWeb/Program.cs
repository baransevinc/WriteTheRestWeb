using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Backend API'ye eriþmek için HttpClient servisi tanýmlanýyor
builder.Services.AddHttpClient<StoriesApiService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7081/"); // API address  
});

builder.Services.AddHttpClient<ChapterApiService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7081/");
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Stories}/{action=Index}/{id?}");

app.Run();
