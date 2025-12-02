using HoE.Components;
using HoE.Plugins.EFCoreSqlServer;
using HoE.Plugins.InMemory;
using HoE.UseCase.PluginInterfaces;
using HoE.UseCase.Teachers;
using HoE.UseCase.Teachers.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextFactory<HoEContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HoEManagement"));
});
builder.Services.AddRazorComponents();

builder.Services.AddSingleton<ITeachersRepository, TeachersRepository>();
builder.Services.AddTransient<IViewTeachersByNameUseCase, ViewTeachersByNameUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
