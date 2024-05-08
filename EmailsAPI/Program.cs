using EmailsAPI.Entities;
using EmailsAPI.Extensions;
using EmailsAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.AddSingleton<ISendEmail, SendEmail>();

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();

var app = builder.Build();

app.UseSwaggerDoc();
app.UseAuthorization();
app.MapControllers();
app.Run();
