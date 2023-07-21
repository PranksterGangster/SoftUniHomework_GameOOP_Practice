namespace DeepRockGalactic.Models.Guns.Contracts;

public interface IShootable
{
    int Damage { get; }
    double RateOfFirePerSecond { get; }
    int MaxAmmo { get; }
    int Shoot(int secondsDuration);
}
