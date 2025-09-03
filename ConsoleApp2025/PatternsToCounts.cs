namespace ConsoleApp2025
{
    public static class PatternsToCounts
    {

      
        public static int TotalPatternCount(int NoPatts, int NoCounts)
        {
            //// declare
            const int Measure = 8;
            const int Phrase = 32;
           
            //// set up
            int totalSongCounts = 9;
            int totalPattCounts =
                        32 + 28 + 32 + 24 + 32 + 32 + 32 + 32;
            //// calc logic
            // 1. Get maxSongCounts
            int maxSongCounts = totalSongCounts * Phrase;

            int fitsDegree = maxSongCounts - totalPattCounts;

            // do patterns exceed song's counts
            if (fitsDegree >= 0)
            {
               
                Console.WriteLine("\n\nFits by\t" + fitsDegree + "\tCounts");

            }

            return fitsDegree;
        }

        ////public static int TotalPatternCount(int NoPatts, int NoCounts, out int FitsDegree)
        ////{
        ////    //// declare
        ////    const int Measure = 8;

        ////    //// set up
        ////    int totalSongCounts = 9;
        ////    int totalPattCounts =
        ////                32 + 28 + 32 + 24 + 32 + 32 + 32;
        ////    //// calc logic
        ////    // 1. Get maxSongCounts
        ////    int maxSongCounts = totalSongCounts * Measure;

        ////    int fitsDegree = maxSongCounts - totalPattCounts;

        ////    // do patterns exceed song's counts
        ////    if (fitsDegree >= 0)
        ////    {
        ////        FitsDegree = fitsDegree;
        ////        Console.WriteLine("\n\n" + FitsDegree.ToString());

        ////    }

        ////    return fitsDegree;
        ////}
    
        //// Data samples
        //  key, song name, length, coutns/beats, measure/Phrases
    
    }
}
