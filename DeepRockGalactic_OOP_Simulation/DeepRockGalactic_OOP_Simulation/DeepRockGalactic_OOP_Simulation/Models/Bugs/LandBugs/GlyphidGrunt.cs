using DeepRockGalactic.Models.Bugs.Abstracts;

namespace DeepRockGalactic.Models.Bugs.LandBugs;

public sealed class GlyphidGrunt : GlyphidBug
{
    private const double defaultWalkingSpeed = 4;
    private const double health = 90;
    private const double damage = 30;

    public GlyphidGrunt()
        : base(health, defaultWalkingSpeed, damage)
    {
    }

    public GlyphidGrunt(DifficultyLevel difficultyScaling)
    : base(health, defaultWalkingSpeed, damage, difficultyScaling)
    {
    }
}
