using DeepRockGalactic.Models.Equipment.Contracts;

namespace DeepRockGalactic.Models.Guns.Contracts;

public interface secondary : IShootable
{
    GunType GunType { get; }
}
