namespace DeepRockGalactic.Models.Contracts;

public interface ICreature : IHurtable, IIdentifyable
{
    string Name { get; }
}
