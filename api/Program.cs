var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
else {
    app.UseStaticFiles();
    app.MapFallbackToFile("index.html");
}

app.MapControllers();

app.Run();