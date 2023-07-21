using DeepRockGalactic.Models.Bugs.Abstracts;

namespace DeepRockGalactic.Models.Bugs.AirBugs;

public sealed class MacteraTrijaw : MacteraBug
{
    private const double defaultFlyingSpeed = 4;
    private const double health = 100;
    private const double damage = 45;

    public MacteraTrijaw()
        : base(health, damage, defaultFlyingSpeed)
    {
    }

    public MacteraTrijaw(DifficultyLevel difficultyModifier)
        : base(health, damage, defaultFlyingSpeed, difficultyModifier)
    {
    }
}
