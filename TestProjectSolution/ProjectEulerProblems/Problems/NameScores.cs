namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for calculating the name score of a file of names.
    /// </summary>
    public static class NameScores
    {
        /// <summary>
        /// Calculates the total sum of the name score of a file.
        /// </summary>
        /// <param name="filePath">Path to file.</param>
        /// <returns>Total sum of the name score.</returns>
        public static int GetTotalOfAllNameScores(string filePath)
        {
            var names = File.ReadAllLines(filePath);

            List<string> orderedNames = names[0].Replace("\"", string.Empty).Split(',').Select(name => name.Trim().Trim('"')).OrderBy(x => x).ToList();

            var totalScore = 0;
            for (int i = 1; i <= orderedNames.Count; i++)
            {
                var name = orderedNames[i - 1];
                totalScore += GetNameValue(name) * i;
            }

            return totalScore;
        }

        /// <summary>
        /// Calculates the alphabetical value of a name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The value of the name.</returns>
        public static int GetNameValue(string name)
        {
            int score = 0;
            foreach (var c in name)
            {
                score += (c - 65) + 1;
            }

            return score;
        }
    }
}
