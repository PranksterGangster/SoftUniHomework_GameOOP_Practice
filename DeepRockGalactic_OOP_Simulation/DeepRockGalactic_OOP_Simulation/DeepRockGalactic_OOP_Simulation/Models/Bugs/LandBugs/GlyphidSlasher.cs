using DeepRockGalactic.Models.Bugs.Abstracts;

namespace DeepRockGalactic.Models.Bugs.LandBugs;

public sealed class GlyphidSlasher : GlyphidBug
{
    private const double defaultWalkingSpeed = 6;
    private const double health = 100;
    private const double damage = 70;

    public GlyphidSlasher() 
        : base(health, defaultWalkingSpeed, damage)
    {
    }

    public GlyphidSlasher(DifficultyLevel difficultyScaling) 
        : base (health, defaultWalkingSpeed, damage, difficultyScaling)
    {
    }
}
