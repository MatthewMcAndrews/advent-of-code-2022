using System.IO;

namespace AdventOfCode
{
    class RockPaperScisors
    {
        public static string Score()
        {
            var lines = File.ReadAllLines("..\\..\\day-2-rock-paper-scissors-stragey-guide.txt");
            var totalScore = 0;
            foreach (var line in lines)
            {
                var turn = line.Split(' ');
                var opponent = turn[0][0];
                var you = turn[1][0];
                var o = Index(opponent);
                var y = Index(you);
                var roundScore = outcomeScore[y, o] + shapeScore[y];
                totalScore += roundScore;
            }
            return totalScore.ToString();
        }
        private static int Index(char c) {
            switch (c)
            {
                case 'A': case 'X': return 0;
                case 'B': case 'Y': return 1;
                case 'C': case 'Z': return 2;
                default: throw new System.Exception();
            }
        }
        private static readonly int[,] outcomeScore = new int[3, 3] {
         //   A  B  C
            { 3, 0, 6 }, // X
            { 6, 3, 0 }, // Y
            { 0, 6, 3 }  // Z
        };
        private static readonly int[] shapeScore = new int[3] {
            1, 2, 3 
        };
    }
}