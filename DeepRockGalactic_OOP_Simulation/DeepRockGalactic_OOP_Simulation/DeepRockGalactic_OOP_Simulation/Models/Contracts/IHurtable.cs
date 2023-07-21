namespace DeepRockGalactic.Models.Contracts;

public interface IHurtable
{
    public double Health { get; }
    public void TakeDamage(double damage);
}
