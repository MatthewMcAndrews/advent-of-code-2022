using System.IO;

namespace AdventOfCode
{
    class RockPaperScisors
    {
        public static string ScoreWithMisunderstanding() => Score(_roundScore);
        public static string ScoreWithUnderstanding() => Score(_desiredScore);
        private static string Score(int[,] score) {
            var lines = File.ReadAllLines("..\\..\\day-2-rock-paper-scissors-stragey-guide.txt");
            var totalScore = 0;
            foreach (var line in lines) {
                var turn = line.Split(' ');
                var opponent = turn[0][0];
                var you = turn[1][0];
                var o = Index(opponent);
                var y = Index(you);
                var roundScore = score[y, o];
                totalScore += roundScore;
            }
            return totalScore.ToString();
        }
        private static int Index(char c) => c switch {
            'A' or 'X' => 0,
            'B' or 'Y' => 1,
            'C' or 'Z' => 2,
            _ => throw new System.Exception(),
        };
        private static readonly int[,] _roundScore = new int[3, 3] {
         //   A  B  C
            { 4, 1, 7 }, // X
            { 8, 5, 2 }, // Y
            { 3, 9, 6 }  // Z
        };
        private static readonly int[,] _desiredScore = new int[3, 3] {
         //   A  B  C
            { 3, 1, 2 }, // X
            { 4, 5, 6 }, // Y
            { 8, 9, 7 }  // Z
        };
    }
}