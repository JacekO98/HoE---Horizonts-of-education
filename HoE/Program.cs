using BlazorIdentity.Example.Components.Account;
using BlazorIdentity.Example.Data;
using HoE.Components;
using HoE.Plugins.EFCoreSqlServer;
using HoE.Plugins.InMemory;
using HoE.UseCase.PluginInterfaces;
using HoE.UseCase.Teachers;
using HoE.UseCase.Teachers.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("HoEAccounts") ?? throw new InvalidOperationException("Connection string 'HoEAccounts' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

// Add services to the container.
builder.Services.AddDbContextFactory<HoEContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HoEAccounts"));
});
builder.Services.AddRazorComponents();

if (builder.Environment.IsEnvironment("Testing"))
{
    StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
    builder.Services.AddSingleton<ITeachersRepository, TeachersRepository>();
    
}
else {
    builder.Services.AddTransient<ITeachersRepository, TeachersEFCoreRepository>();
    
}
builder.Services.AddTransient<IViewTeachersByNameUseCase, ViewTeachersByNameUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
