using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Dwarves;

public class Engineer : Dwarf
{
    private static readonly string[] selectedVoiceLines = VoiceLines.EngineerLines;

    public Engineer(Primary primary, Secondary secondary)
        : base(primary, secondary, selectedVoiceLines)
    {

    }
}
