using Microsoft.EntityFrameworkCore;
using WebMVCDemo;
using WebMVCDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDBContext>(options =>
{
    options.UseMySql("server=localhost;port=3306;user=root;password=linh17423;database=lh_data", ServerVersion.AutoDetect("server=localhost;port=3306;user=root;password=linh17423;database=lh_data"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("/", async context =>
    {
        var menu = HtmlHelper.MenuTop
        (
           HtmlHelper.DefaultMenuTopItems(), context.Request
        );

        var html = HtmlHelper.HtmlDocument("XIN CHAO", menu + HtmlHelper.HtmlTrangchu());
        await context.Response.WriteAsync(html);
    });

    _ = endpoints.MapGet("/Endcoding", async context =>
    {
        await context.Response.WriteAsync("Endcoding");
    });
    _ = endpoints.MapGet("/Cookies", async context =>
    {
        await context.Response.WriteAsync("Cookies");
    });
    _ = endpoints.MapGet("/Json", async context =>
    {
        await context.Response.WriteAsync("Json");
    });
    _ = endpoints.MapGet("/Form", async context =>
    {
        await context.Response.WriteAsync("Form");
    });
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
