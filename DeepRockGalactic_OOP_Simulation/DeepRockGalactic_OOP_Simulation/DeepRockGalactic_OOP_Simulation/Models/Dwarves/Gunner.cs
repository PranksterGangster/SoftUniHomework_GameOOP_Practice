using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Dwarves;

public class Gunner : Dwarf
{
    private static readonly string[] selectedVoiceLines = VoiceLines.GunnerLines;

    public Gunner(Primary primary, Secondary secondary)
        : base(primary, secondary, selectedVoiceLines)
    {

    }
}
