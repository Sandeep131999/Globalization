using Try.Services;

var builder = WebApplication.CreateBuilder(args);
//****************************************
// Add services to the container.
//****************************************
builder.Services.AddRazorPages();
//****************************************
//Add localization services and specify the path to the resource files
//****************************************
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
//****************************************
//Configure localization options
//****************************************
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("ja-JP"),
        new CultureInfo("en-IN"),
    };
    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
//****************************************
//Add the SharedResourceService as a singleton service
//****************************************
builder.Services.AddSingleton<SharedResourceService>();

builder.Services.AddControllersWithViews();

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

//****************************************
//Retrieve the configured RequestLocalizationOptions from the service provider
//****************************************
var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localizationOptions.Value);

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
