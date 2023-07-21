using DeepRockGalactic.Models.Contracts;
using DeepRockGalactic.Models.Dwarves.Contracts;
using DeepRockGalactic.Models.Guns.Abstracts;
using System;
using System.Linq;

namespace DeepRockGalactic.Models.Dwarves;

public abstract class Dwarf : IDwarf
{
    private const double defaultHealth = 150;

    protected Dwarf(Primary primary, Secondary secondary, string[] selectedVoiceLine)
    {
        Health = defaultHealth;
        Primary = primary;
        Secondary = secondary;
        SelectedVoiceLine = selectedVoiceLine.ToArray();
        SayVoiceLine();
    }


    public double Health { get; protected set; }

    public Primary Primary { get; private set; }

    public Secondary Secondary { get; private set; }

    public string[] SelectedVoiceLine { get; private set; }

    public string Name => this.GetType().Name;

    public virtual string Identify()
    {
        return $"Identifying... Dwarf: {Name}, FRIENDLY";
    }

    public void ShootPrimary(IHurtable target, int secondsDuration)
    {
        int dealtDamage = Primary.Shoot(secondsDuration);
        target.TakeDamage(dealtDamage);
    }

    public void ShootSecondary(IHurtable target, int secondsDuration)
    {
        int dealtDamage = Secondary.Shoot(secondsDuration);
        target.TakeDamage(dealtDamage);
    }

    public void TakeDamage(double damage)
    {
        if (Health - damage >= 0)
        {
            Health -= damage;
        }
    }

    private void SayVoiceLine()
    {
        Random random = new Random();

        Console.WriteLine(SelectedVoiceLine[random.Next(0, 3)]);
    }
}
