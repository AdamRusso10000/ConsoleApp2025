// See https://aka.ms/new-console-template for more information
using ConsoleApp2025;

Console.WriteLine("Hello, Dance Patterns World!");
Console.WriteLine("");
Console.WriteLine("\nSong Length and time:\t Simple & 3:05");
Console.WriteLine("");
Console.WriteLine("Total Musical Measures in song:\t 9");
Console.WriteLine("");
Console.WriteLine("Total Musical Measures in song:\t 9");
Console.WriteLine("\n");
Console.WriteLine("Patterns: 52, 26 RRL, 81AA, 85, 88-Lasso, 13, 62, 16 Prin Dip");
Console.WriteLine("\nCount Per: 32, 28, 32, 24, 32, 32, 32, 32");

Console.WriteLine("32, 26 RRL, 81AA, 85, 88, 13, 16 Prin Dip");
////Console.ReadLine();
Console.WriteLine("\n \nResults-Output");
int totalPatternCount = PatternsToCounts.TotalPatternCount(7, 9);
Console.WriteLine("\ntotalPatternCount:\t" + totalPatternCount);

Console.WriteLine("\n\n\n\n A Phrase is 32 Counts/beats in a song." +
"\nSo an 8 count song, is 4 measures per phrase, equaling 32 Counts");

Console.WriteLine("\n A Phrase Change 1" +
"\nis the 1st count of new Phrase");

Console.WriteLine("\n\n\n\n");

Console.WriteLine("--App Synapsys--");
Console.WriteLine("\nBusiness Solution: In the world of Dance, either professional or Amatuer,\n" +
    "there is a need to Choreograph.");
Console.WriteLine("This app's algorithm allows mixing and matching Dance Patterns to \"Fit\" in\n" + 
    "the Song's musical measures.");
Console.WriteLine("\nSong Length and time:\t Simple & 3:05");
Console.WriteLine("Example is in Country \"2-Step\" partner dance,\n" +
    "there is a move called the \"Lasso\" and it can be accomplished in 32 Counts.");
Console.WriteLine("There is about Nine 32 counts, 'aka Musical Phrase (8 Count)'.");
Console.WriteLine("Sometimes, we want to switch out Dance Moves, 'aka Patterns'.");
Console.WriteLine("But we need to know if the changes will 'Fit' in the music.");
Console.WriteLine("\tWe have Patterns within a Dance song music measures.");
Console.WriteLine("Yes, a ledger with a pencil and eraser works,\n" +
    "but more time consimung than an App.");

Console.WriteLine("\n\n\n");
Console.ReadLine(); 
