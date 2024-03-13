using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Domain.Interfaces.IServices;
using TaskWave.Infrastructure.Repositories;
using TaskWave.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ����������� �����������
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

// ����������� ��������
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
