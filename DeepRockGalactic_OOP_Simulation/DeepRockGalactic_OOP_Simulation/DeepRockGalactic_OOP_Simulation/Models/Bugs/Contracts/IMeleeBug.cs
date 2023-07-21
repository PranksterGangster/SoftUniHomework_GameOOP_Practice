using DeepRockGalactic.Models.Contracts;

namespace DeepRockGalactic.Models.Bugs.Contracts;

public interface IMeleeBug : IHostileBug
{
    public void MeleeAttack(IHurtable target);
}
