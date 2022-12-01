using System;

namespace AdventOfCode {
    class Program {
        static void Main(string[] args) {
            try
            {
                int dayOfChristmas = int.Parse(args[0]);
                int challengeNumber = int.Parse(args[1]);
                string answer = GetAnswerFor((dayOfChristmas, challengeNumber));
                Console.WriteLine(answer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        public static string GetAnswerFor((int dayOfChristmas, int challengeNumber) id) => id switch
        {
            (1, 1) => ElfCalories.MaxCarried(),
            (1, 2) => ElfCalories.SumOfTopThree(),
            _ => throw new Exception($"unsupported day of christmas {id.dayOfChristmas}, challenge {id.challengeNumber}."),
        };
    }
}