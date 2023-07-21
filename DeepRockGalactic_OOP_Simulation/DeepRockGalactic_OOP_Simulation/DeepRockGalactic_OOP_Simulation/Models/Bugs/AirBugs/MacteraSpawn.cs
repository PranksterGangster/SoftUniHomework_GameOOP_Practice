using DeepRockGalactic.Models.Bugs.Abstracts;

namespace DeepRockGalactic.Models.Bugs.AirBugs;

public sealed class MacteraSpawn : MacteraBug
{
    private const double defaultFlyingSpeed = 4;
    private const double health = 90;
    private const double damage = 30;

    public MacteraSpawn() 
        : base(health, damage, defaultFlyingSpeed)
    {
    }

    public MacteraSpawn( DifficultyLevel difficultyModifier) 
        : base( health, damage, defaultFlyingSpeed,difficultyModifier)
    {
    }
}
