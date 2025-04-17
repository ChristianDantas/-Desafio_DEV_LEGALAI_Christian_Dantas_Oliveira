var builder = WebApplication.CreateBuilder(args);

// Configuração de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();

// Ativando o CORS
app.UseCors("PermitirTudo");


app.UseAuthorization();
app.MapControllers();

app.Run();