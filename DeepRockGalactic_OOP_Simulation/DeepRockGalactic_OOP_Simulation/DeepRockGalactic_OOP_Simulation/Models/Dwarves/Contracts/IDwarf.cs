using DeepRockGalactic.Models.Contracts;
using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Dwarves.Contracts;

public interface IDwarf : ICreature, IShootableGun, IHurtable
{
    public Primary Primary { get; }
    public Secondary Secondary { get; }
    public string[] SelectedVoiceLine { get; }
}
