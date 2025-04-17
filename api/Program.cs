using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlite("Data Source=touhou.db");
});

var app = builder.Build();

using (var scope = app.Services.CreateScope()) {
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();

    if (!db.Games.Any()) {
        db.Games.AddRange(
            new Game {
                Title = "Touhou 6: Embodiment of Scarlet Devil",
                ReleaseOrder = 6,
                ImageName = "touhou_6.jpg",
                Characters = new List<Character> {
                    new Character {
                        Name = "Reimu Hakurei",
                        ImageName = "reimu.jpg",
                        Abilities = ["Flight", "Danmaku"],
                        Description = "Главная героиня серии",
                        ThemeSong = "Maiden's Capriccio"
                    }
                }
            },
            new Game {
                Title = "Touhou 7: Perfect Cherry Blossom",
                ReleaseOrder = 7,
                ImageName = "touhou_7.jpg"
            }
        );

        db.SaveChanges();
    }

}

if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
else {
    app.UseStaticFiles();
    app.MapFallbackToFile("index.html");
}

app.MapControllers();

app.Run();