using DeepRockGalactic.Models.Contracts;

namespace DeepRockGalactic.Models.Bugs.Contracts;

public interface IRangedAttack : IHostileBug
{
    public void RangedAttack(IHurtable target);
}
