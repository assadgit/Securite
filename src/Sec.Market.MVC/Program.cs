using Azure.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.IdentityModel.Tokens;
using Sec.Market.MVC.Interfaces;
using Sec.Market.MVC.Services;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// source de ce code :  https://stackoverflow.com/questions/56179837/how-to-get-generate-access-token-from-azure-oauth-2-0-token-v2-endpoints
var client = ConfidentialClientApplicationBuilder
    .Create("37fbb534-b6ba-405f-ab2c-7ad2da4850ac")
    .WithAuthority("https://login.microsoftonline.com/5650116c-e301-4b3f-a9ea-d4c8bf6fe2bf/oauth2/v2.0")
    .WithClientSecret("fvU8Q~an19srd5WHbUeV.VsXTdGhh2kxrhF~ocva")
    .Build();
var result = await client.AcquireTokenForClient(new[] { "api://6a915acd-e91a-4bda-a4bc-94e923987f95/.default" })
            .ExecuteAsync();
var accessToken = result.AccessToken;




// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IProductService, ProductServiceProxy>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("UrlApi"));
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
});

builder.Services.AddHttpClient<IUserService, UserServiceProxy>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("UrlApi"));
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
});
builder.Services.AddHttpClient<IOrderService, OrderServiceProxy>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("UrlApi"));
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
});
builder.Services.AddHttpClient<ICustomerReviewService, CustomerReviewServiceProxy>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("UrlApi"));
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
});

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".Auth";
    options.IdleTimeout = TimeSpan.FromMinutes(1);
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
