using BarSplitterMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Se voce quiser conectar no seu banco, essa Connection String ira variar.
// Em password, voce deve colocar a senha do usuario root na sua maquina
// No MySqlServerVersion voce deve colocar a versão do seu MySql Workbbench antes de -mysql.
builder.Services.AddDbContext<Context>(options => options.UseMySql(
    "server=localhost;user=root;password=lucas123;database=BarSplitter",
    new MySqlServerVersion(new Version(8, 0, 33))
    )
);

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
