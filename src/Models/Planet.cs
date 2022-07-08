namespace MauiPlanets.Models;

internal class Planet
{
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public string HeroImage { get; set; }
    public string Description { get; set; }
    public Color AccentColorStart { get; set; }
    public Color AccentColorEnd { get; set; }
    public List<string> Images { get; set; }
}