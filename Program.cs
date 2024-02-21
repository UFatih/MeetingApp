var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

// mvc
// rest api
// razor pages

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/meet", () => "Animals get along by sniffing, people get along by talking. \n divanü lugati't-türk ");

// {controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute();    ctrl + k + C yorum yaptırır.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();
