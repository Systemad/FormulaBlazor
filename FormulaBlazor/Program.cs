using FormulaBlazor.Data;
using FormulaBlazor.Features.Common;
using FormulaBlazor.Features.Common.Ergast;
using FormulaBlazor.Features.Common.Wikipedia;
using FormulaBlazor.Features.Theme;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddHttpClient<IBaseErgastClient, BaseErgastClient>(
    "ergast",
    options =>
    {
        options.BaseAddress = new Uri("http://ergast.com/api/f1/");
    }
); //.AddHttpMessageHandler<FixUrlJsonHandler>();
builder.Services.AddHttpClient<IWikiBaseClient, WikiBaseClient>(
    "wikipedia",
    options =>
    {
        options.BaseAddress = new Uri("https://en.wikipedia.org/api/rest_v1/page/summary/");
    }
);
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ThemeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
