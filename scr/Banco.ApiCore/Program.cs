using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Banco.ApiCore.Configuration;
using Banco.ApiCore.Data;
using Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

builder.Services.AddIdentityConfig(builder.Configuration);

//builder.Services.AddDbContext<MeuDbContext>(options =>
//{
//    //MYSQL
//    options.UseMySql("server=mysql-banco-api.mysql.database.azure.com;initial catalog=BancoBB;uid=MysqlRoot;pwd=4Ucode00",
//    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
//    //SQLSERVER
//    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

//});

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    //MYSQL
//    options.UseMySql("server=mysql-banco-api.mysql.database.azure.com;initial catalog=BancoBB;uid=MysqlRoot;pwd=4Ucode00",
//    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
//    //SQLSERVER
//    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

//});

builder.Services.AddApiConfig();
builder.Services.AddSwaggerConfig();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.ResolveDependencies();

var app = builder.Build();
var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

app.UseApiConfig(app.Environment);
app.UseSwaggerConfig(apiVersionDescriptionProvider);

app.Run();
