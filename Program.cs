using APISenf.Services.BhIss.LoteRps;
using APISenf.Services.BhIss.Nfse;
using APISenf.Services.BhIss.NfsePorRps;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IConsultaNfseService, ConsultaNfseService>();
builder.Services.AddScoped<IConsultarNfsePorRpsService, ConsultarNfsePorRpsService>();
builder.Services.AddScoped<IConsultarLoteRpsService, ConsultarLoteRpsService>();
builder.Services.AddScoped<IConsultarSituacaoLoteRpsService, ConsultarSituacaoLoteRpsService>();
builder.Services.AddScoped<IEnvioLoteRpsService, EnvioLoteRpsService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
