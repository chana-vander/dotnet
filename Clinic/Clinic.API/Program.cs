using Clinic.Core;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
using Clinic.Data;
using Clinic.Data.Repositories;
using Clinic.Data.Repository;
using Clinic.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//:הזרקת התלויות
//doctor:
builder.Services.AddScoped<IDoctorsService, DoctorsService>();
builder.Services.AddScoped<IDoctorsRepository, DoctorsRepository>();
//patient:
builder.Services.AddScoped<IPatientService,PatientService>();
builder.Services.AddScoped<IPatientRepository,PatientRepository>();
//prescription
builder.Services.AddScoped<IPrescriptionService, PrescriptionService>();
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();
//data
builder.Services.AddSingleton<DataContext>();

//add today
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
//db:
builder.Services.AddDbContext<DataContext>();
//AoutoMapper -הזרקה ל
builder.Services.AddAutoMapper(typeof(MappingProfile2));
//mapping-הזרקה ל
builder.Services.AddSingleton<Mapping>();
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
