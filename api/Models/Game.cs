public class Game {
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public int ReleaseOrder { get; set; }
    public string ImageName { get; set; } = "";
    public List<Character> Characters { get; set; } = [];
}
