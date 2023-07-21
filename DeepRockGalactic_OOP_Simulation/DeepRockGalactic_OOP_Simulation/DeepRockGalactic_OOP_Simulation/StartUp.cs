using DeepRockGalactic.Models.Bugs.Abstracts;
using DeepRockGalactic.Models.Bugs.LandBugs;
using DeepRockGalactic.Models.Dwarves;
using DeepRockGalactic.Models.Dwarves.Contracts;
using DeepRockGalactic.Models.Guns.Abstracts;
using DeepRockGalactic.Models.Guns.Primaries;
using DeepRockGalactic.Models.Guns.Secondaries;
using System;

public class StartUp
{
    static void Main()
    {
        Primary primary = new LeadStorm();
        Secondary secondary = new BulldogHeavyRevolver();

        IDwarf dwarf = new Gunner(primary, secondary);
        Console.WriteLine(dwarf.Identify());

        GlyphidGrunt grunt = new GlyphidGrunt();
        Console.WriteLine(grunt.Identify());
        Console.WriteLine($"{grunt.Name} has walking speed of {grunt.CrawlingSpeed}");

        grunt.DifficultyModifier = DifficultyLevel.Extreme;
        Console.WriteLine($"{grunt.Name} has walking speed of {grunt.CrawlingSpeed}");

    }
}
