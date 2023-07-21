namespace DeepRockGalactic.Models.Guns.Contracts;

public interface IReloadable
{
    int MagazineSize { get; }
    double ReloadTime { get; }
}
