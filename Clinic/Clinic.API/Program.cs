using Clinic.Core.Repositories;
using Clinic.Core.Services;
using Clinic.Data;
using Clinic.Data.Repositories;
using Clinic.Data.Repository;
using Clinic.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//:����� �������
//doctor:
builder.Services.AddScoped<IDoctorsService, DoctorsService>();
builder.Services.AddScoped<IDoctorsRepository, DoctorsRepository>();
//builder.Services.AddSingleton<DataContext>();
//patient:
builder.Services.AddScoped<IPatientService,PatientService>();
builder.Services.AddScoped<IPatientRepository,PatientRepository>();
//prescription
builder.Services.AddScoped<IPrescriptionService, PrescriptionService>();
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();


//db:
builder.Services.AddDbContext<DataContext>();


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
