using GitHubIntegration.Service.Models;
using GitHubIntegration.Service;

var builder = WebApplication.CreateBuilder(args);

// הגדרת CORS - מאפשר ל-Frontend לגשת ל-API
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// הגדרות מערכת
builder.Services.Configure<GitHubSettings>(builder.Configuration.GetSection("GitHubSettings"));
builder.Services.AddMemoryCache();
builder.Services.AddScoped<GitHubService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); // הפעלת ה-CORS
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseDefaultFiles(); // גורם לשרת לחפש אוטומטית את index.html
app.UseStaticFiles();  // מאפשר להגיש קבצים מתיקיית wwwroot
app.MapControllers();

app.Run();