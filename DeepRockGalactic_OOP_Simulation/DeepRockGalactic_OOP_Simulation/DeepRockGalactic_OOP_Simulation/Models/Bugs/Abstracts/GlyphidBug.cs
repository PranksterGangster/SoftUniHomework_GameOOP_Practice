using DeepRockGalactic.Models.Bugs.Contracts;
using DeepRockGalactic.Models.Contracts;
using System;

namespace DeepRockGalactic.Models.Bugs.Abstracts;

public abstract class GlyphidBug : Bug, ILandBug, IMeleeBug
{
    protected GlyphidBug(double health, double defaultSpeed, double damage)
        : base(health)
    {
        DefaultSpeed = defaultSpeed;
        Damage = damage;
    } 

    protected GlyphidBug(double health, double defaultSpeed, double damage, DifficultyLevel difficultyScaling)
        : base(health, difficultyScaling)
    {
        DefaultSpeed = defaultSpeed;
        Damage = damage;
    }

    public double DefaultSpeed { get; }

    public double CrawlingSpeed => DefaultSpeed * (double)DifficultyModifier / 10.0;

    public double Damage { get; private set; }

    public virtual void Crawl(double seconds)
    {
        Console.WriteLine("*tap tap tap tap tap*");
    }

    public virtual void MeleeAttack(IHurtable target)
    {
        target.TakeDamage(Damage);
    }
}
