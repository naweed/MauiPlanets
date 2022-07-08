namespace MauiPlanets.Services;

internal static class PlanetsService
{
	private static  List<Planet> planets = new()
	{
		new()
		{
			Name = "Mercury",
			Subtitle = "",
			HeroImage = "mercury.png",
			Description = "",
			AccentColorStart = null,
			AccentColorEnd = null,
			Images = new()
            {
				"",
				"",
				""
            }
		},
        new()
        {
            Name = "Venus",
            Subtitle = "",
            HeroImage = "venus.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Earth",
            Subtitle = "",
            HeroImage = "earth.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Mars",
            Subtitle = "",
            HeroImage = "mars.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Jupiter",
            Subtitle = "",
            HeroImage = "jupiter.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Saturn",
            Subtitle = "",
            HeroImage = "saturn.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Uranus",
            Subtitle = "",
            HeroImage = "uranus.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        },
        new()
        {
            Name = "Neptune",
            Subtitle = "",
            HeroImage = "neptune.png",
            Description = "",
            AccentColorStart = null,
            AccentColorEnd = null,
            Images = new()
            {
                "",
                "",
                ""
            }
        }
    };

	public static List<Planet> GetAllPlanets()
		=> planets;

    public static Planet GetPlanet(string planetName)
		=> planets.Where(_planet => _planet.Name == planetName).FirstOrDefault();

    public static List<Planet> GetFeaturedPlanets()
    {
        var rnd = new Random();
        var randomizedPlanets = planets.OrderBy(item => rnd.Next());

		return randomizedPlanets.Take(2).ToList();
    }
        

}

