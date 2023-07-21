using DeepRockGalactic.Models.Contracts;

namespace DeepRockGalactic.Models.Bugs.Abstracts;

public abstract class Bug : IHurtable, ICreature, IDifficultyScalable
{
    protected Bug(double health)
    {
        Health = health;
        DifficultyModifier = DifficultyLevel.LowRisk;
    }

    protected Bug(double health, DifficultyLevel difficultyScaling)
        :this (health)
    {
        DifficultyModifier = difficultyScaling;
    }

    public DifficultyLevel DifficultyModifier { get; set; }

    public string Name => this.GetType().Name;

    public double Health { get; private set; }

    public string Identify()
    {
        return $"Identifying... Bug: {Name}, HOSTILE";
    }

    public virtual void TakeDamage(double damage)
    {
        if (Health - damage <= 0)
        {
            Health -= damage;
        }
    }
}
