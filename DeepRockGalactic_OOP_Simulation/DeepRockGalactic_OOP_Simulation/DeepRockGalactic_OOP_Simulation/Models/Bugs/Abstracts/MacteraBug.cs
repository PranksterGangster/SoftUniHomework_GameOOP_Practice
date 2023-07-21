using System;
using DeepRockGalactic.Models.Bugs.Contracts;
using DeepRockGalactic.Models.Contracts;

namespace DeepRockGalactic.Models.Bugs.Abstracts
{
    public abstract class MacteraBug : Bug, IAirBug, IRangedAttack

    {
        protected MacteraBug(double health, double damage, double defaultSpeed)
            : base(health)
        {
            Damage = damage;
            DefaultSpeed = defaultSpeed;
        }

        protected MacteraBug(double health, double damage, double defaultSpeed, DifficultyLevel difficultyModifier)
            : base(health, difficultyModifier)
        {
            Damage = damage;
            DefaultSpeed = defaultSpeed;
        }

        public double Damage { get; private set; }

        public double FlyingSpeed { get; private set; }

        public double DefaultSpeed { get; private set; }

        public virtual void Fly(double seconds)
        {
            Console.WriteLine("*flutter flutter flutter*");
        }

        public virtual void RangedAttack(IHurtable target)
        {
            target.TakeDamage(Damage);
        }
    }
}
