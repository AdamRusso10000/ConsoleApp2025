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
Console.WriteLine("Patterns: 52, 26 RRL, 81AA, 85, 88, 13, 62, 16 Prin Dip");
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