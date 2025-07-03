
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using FinTrackPro.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FinTrackPro.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
