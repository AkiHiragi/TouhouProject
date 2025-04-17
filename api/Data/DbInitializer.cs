public class DbInitializer {
    public static async Task InitializeAsync(AppDbContext db) {
        await db.Database.EnsureCreatedAsync();

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

            await db.SaveChangesAsync();
        }
    }
}
