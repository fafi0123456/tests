using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ Razor Pages (nếu có giao diện)
builder.Services.AddRazorPages();

var app = builder.Build();

// Cấu hình pipeline xử lý HTTP requests
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages(); // Nếu dùng Razor Pages
app.MapGet("/", () => "Hello, .NET Core 9.0!"); // Endpoint đơn giản

app.Run();
