using DeepRockGalactic.Models.Equipment.Contracts;

namespace DeepRockGalactic.Models.Guns.Abstracts;

public abstract class Primary : NonReloadableGun, ISlottable
{
    protected Primary(GunType gunType, int maxAmmo, int damage, double rateOfFirePerSecond)
        : base(gunType, maxAmmo, damage, rateOfFirePerSecond)
    {
        Slot = EquipmentSlot.Primary;
    }

    public EquipmentSlot Slot { get; }
}
