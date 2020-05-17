using System;

namespace GoogleCompetitionTemplate
{
    internal class Program
    {
        private static int n=0;
        private static int k=0;
        
        public static void Main(string[] args)
        {
            int t = getNumberOfTestCases();
            for (int i = 0; i <= t; i++)
            {
                int[] lenghts = getLenghts();
                int[] testData = getTestCaseData();
                Console.WriteLine("n" + lenghts[0]);
                Console.WriteLine("k" + lenghts[1]);
                    
                
                foreach (var a in testData)
                {
                    Console.Write(a);
                }
            }
            
        }

        public static int getNumberOfTestCases()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[] getLenghts()
        {
            String[] split = Console.ReadLine().Split(' ');
            int[] lenghts = new int[2];
            if(split.Length>2)
                throw new Exception();
            int i = 0;
            foreach (var lenght in split)
            {
                lenghts[i] = Convert.ToInt32(lenght);
                i++;
            }

            n = lenghts[0];
            k = lenghts[1];
            return lenghts;
        }

        public static int[] getTestCaseData()
        {
            String[] split = Console.ReadLine().Split(' ');
            int[] testData = new int[n];
            if (split.Length > n)
                throw new Exception();
            int i = 0;
            foreach (var testVal in split)
            {
                testData[i] = Convert.ToInt32(testVal);
                i++;
            }

            return testData;
        }
    }
}