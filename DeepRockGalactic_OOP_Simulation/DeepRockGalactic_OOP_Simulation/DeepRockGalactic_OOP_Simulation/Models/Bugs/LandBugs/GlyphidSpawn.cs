using DeepRockGalactic.Models.Bugs.Abstracts;

namespace DeepRockGalactic.Models.Bugs.LandBugs;

public sealed class GlyphidSpawn : GlyphidBug
{
    private const double defaultWalkingSpeed = 5;
    private const double health = 5;
    private const double damage = 10;

    public GlyphidSpawn()
        : base(health, defaultWalkingSpeed, damage)
    {

    }

    public GlyphidSpawn(DifficultyLevel difficultyScaling)
        : base(health, defaultWalkingSpeed, damage, difficultyScaling)
    {

    }
}
