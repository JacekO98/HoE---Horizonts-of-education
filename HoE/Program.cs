using HoE.Components;
using HoE.Plugins.EFCoreSqlServer;
using HoE.Plugins.InMemory;
using HoE.UseCase.PluginInterfaces;
using HoE.UseCase.Teachers;
using HoE.UseCase.Teachers.Interfaces;
using HoE.UseCase.Students;
using HoE.UseCase.Students.Interfaces;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using HoE.UseCase.TAvaliable.Interfaces;
using HoE.UseCase.TAvaliable;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextFactory<HoEContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HoEManagement"));
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

//Teachers Connections
builder.Services.AddTransient<IViewTeachersByNameUseCase, ViewTeachersByNameUseCase>();
builder.Services.AddSingleton<IAddTeacherUseCase, AddTeacherUseCase>();
builder.Services.AddSingleton<IDeleteTeacherUseCase, DeleteTeacherUseCase>();
builder.Services.AddTransient<IViewTeachersByIdUseCase, ViewTeachersByIdUseCase>();

// Students Connections
builder.Services.AddTransient<IStudentsRepository, StudentsRepository>();
builder.Services.AddTransient<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();

//TeachersBookSlots Connections
builder.Services.AddTransient<ITAvaliableNewRepository, TAvaliableNewRepository>();
builder.Services.AddTransient<ITeacherBookSlot, TeacherBookSlot>();

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
