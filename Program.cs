using System;
using System.Collections.Generic;

namespace AdventOfCode {
    class Program {
        static void Main() {
            try { ShowAnswers(); } 
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.ReadLine();
        }
        private static readonly List<Func<string>> solutions = new List<Func<string>>() {
            ElfCalories.MaxCarried,
            ElfCalories.SumOfTopThree,
            RockPaperScisors.ScoreWithMisunderstanding,
            RockPaperScisors.ScoreWithUnderstanding
        };
        private static void ShowAnswers() {
            var dayOfChristmas = 1;
            var challengeNumber = 1;
            Console.WriteLine("(Day, Challenge): Answer");
            foreach (var solution in solutions) {
                var answer = solution();
                Console.WriteLine($"({dayOfChristmas}, {challengeNumber}): {answer}");
                if (challengeNumber % 2 == 0) {
                    dayOfChristmas++;
                    challengeNumber = 0;
                }
                challengeNumber++;
            }
        }
    }
}