using DeepRockGalactic.Models.Equipment.Contracts;

namespace DeepRockGalactic.Models.Guns.Contracts;

public interface IGun : IShootable
{
    GunType GunType { get; }
}