using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// IoC 
// Ýçinde data tutmuyorsak singleton kullanýrýz.
builder.Services.AddScoped<IUserService,UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<IRoleDal,EfRoleDal>();

builder.Services.AddSingleton<IJobTypeService, JobTypeManager>();
builder.Services.AddSingleton<IJobTypeDal, EfJobTypeDal>();

builder.Services.AddSingleton<IJobSeekerService,JobSeekerManager>();
builder.Services.AddSingleton<IJobSeekerDal, EfJobSeekerDal>();

builder.Services.AddSingleton<IJobListingService,JobListingManager>();
builder.Services.AddSingleton<IJobListingDal, EfJobListingDal>();

builder.Services.AddSingleton<IEmployerService, EmployerManager>();
builder.Services.AddSingleton<IEmployerDal,EfEmployerDal>();

builder.Services.AddSingleton<IApplicationStatusService, ApplicationStatusManager>();
builder.Services.AddSingleton<IApplicationStatusDal, EfApplicationStatusDal>();

builder.Services.AddSingleton<IApplicationService, ApplicationManager>();
builder.Services.AddSingleton<IApplicationDal, EfApplicationDal>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
