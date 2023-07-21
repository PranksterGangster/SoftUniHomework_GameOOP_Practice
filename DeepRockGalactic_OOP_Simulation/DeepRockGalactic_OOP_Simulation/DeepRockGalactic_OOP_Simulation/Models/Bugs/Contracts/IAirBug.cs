namespace DeepRockGalactic.Models.Bugs.Contracts;

public interface IAirBug
{
    public double FlyingSpeed { get; }
    public double DefaultSpeed { get; }
    public void Fly(double seconds);
}
