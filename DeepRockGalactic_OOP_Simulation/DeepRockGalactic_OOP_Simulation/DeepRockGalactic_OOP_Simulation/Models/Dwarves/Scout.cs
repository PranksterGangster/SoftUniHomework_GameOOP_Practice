using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Dwarves
{
    public class Scout : Dwarf
    {
        private static readonly string[] selectedVoiceLines = VoiceLines.ScoutLines;

        public Scout(Primary primary, Secondary secondary, string[] selectedVoiceLine)
            : base(primary, secondary, selectedVoiceLine)
        {
        }
    }
}
