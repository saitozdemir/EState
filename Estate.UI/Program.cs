using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Data;
using EntityLayer.Entity;
using Estate.UI.Areas.Admin.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<DataContext>(conf => conf.UseSqlServer());
builder.Services.AddDbContext<DataContext>(conf => conf.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")).UseLazyLoadingProxies());

builder.Services.AddIdentity<UserAdmin, IdentityRole>()
    .AddEntityFrameworkStores<DataContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedAccount = false;


    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 8;
    options.User.AllowedUserNameCharacters = "abcçdefgðhýijklmnoöprsþtuüvyzABCÇDEFGÐHIIJKLMNOÖPRSTUÜVYZ0123456789-._@+";

});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Admin/Admin/Login";
    options.LogoutPath = "/Admin/Admin/Logout";
    options.AccessDeniedPath = "/Admin/Account/AccessDeniedPath";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(6);
});
builder.Services.AddSession();
builder.Services.AddScoped<IAdvertService, AdvertManager>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<IDistrictService, DistrictManager>();
builder.Services.AddScoped<IGeneralSettingsService, GeneralSettingsManager>();
builder.Services.AddScoped<IImagesService, ImagesManager>();
builder.Services.AddScoped<INeighbourhoodService, NeighbourhoodManager>();
builder.Services.AddScoped<ISituationService, SituationManager>();
builder.Services.AddScoped<ITypeService, TypeManager>();
builder.Services.AddScoped<IAdvertRepository, EfAdvertRepository>();




var app = builder.Build();

app.PrepareDatabase().GetAwaiter().GetResult();

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

app.UseAuthorization();
app.UseSession();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
