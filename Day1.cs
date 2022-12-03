using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    class ElfCalories
    {
        public static string MaxCarried() => CalorieCounts().Max().ToString();
        public static string SumOfTopThree() => CalorieCounts().Take(3).Sum().ToString();
        private static List<int> CalorieCounts() {
            var lines = File.ReadAllLines("..\\..\\day-1-elf-calories.txt");
            var calorieCounts = new List<int>();
            var elfCalories = 0;
            foreach (var line in lines) {
                if (int.TryParse(line, out int calories)) {
                    elfCalories += calories;
                } else {
                    calorieCounts.Add(elfCalories);
                    elfCalories = 0;
                }
            }
            calorieCounts.Sort();
            calorieCounts.Reverse();
            return calorieCounts;
        }
    }
}