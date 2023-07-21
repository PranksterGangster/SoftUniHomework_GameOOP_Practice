using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Dwarves;

public class Driller : Dwarf
{
    private static readonly string[] selectedVoiceLines = VoiceLines.DrillerLines;

    public Driller(Primary primary, Secondary secondary)
        : base(primary, secondary, selectedVoiceLines)
    {

    }
}
