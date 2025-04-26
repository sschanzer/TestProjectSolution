using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Utility
{
    /// <summary>
    /// A utility class for parsing various file types.
    /// </summary>
    public class FileParser
    {
        /// <summary>
        /// Private backer for the file path.
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileParser"/> class with the specified file path.
        /// </summary>
        /// <param name="filePath">The full path to the file to parse.</param>
        /// <exception cref="ArgumentException">Thrown when the file path is null or empty.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the file does not exist.</exception>
        public FileParser(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentNullException("File path cannot be null or empty.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found at path: {Path.GetFullPath(filePath)}.", nameof(filePath));
            }

            this.filePath = filePath;
        }

        /// <summary>
        /// Reads all lines from the file.
        /// </summary>
        /// <returns>An array of strings where each element represents a line in the file.</returns>
        public string[] ReadAllLines()
        {
            return File.ReadAllLines(this.filePath);
        }

        /// <summary>
        /// Reads the entire file content as a single string.
        /// </summary>
        /// <returns>The complete file content as a string.</returns>
        public string ReadAllText()
        {
            return File.ReadAllText(this.filePath);
        }

        /// <summary>
        /// Parses a plain text file where each line represents a row of space-separated integers.
        /// </summary>
        /// <returns>A two-dimensional array of integers parsed from the file.</returns>
        public int[,] ParseTextFileAsIntegerGrid()
        {
            return ParseTextFileAsGrid<int>(s => int.Parse(s));
        }

        /// <summary>
        /// Parses a plain text file where each line represents a row of space-separated doubles.
        /// </summary>
        /// <returns>A two-dimensional array of doubles parsed from the file.</returns>
        public double[,] ParseTextFileAsDoubleGrid()
        {
            return ParseTextFileAsGrid<double>(s => double.Parse(s));
        }

        /// <summary>
        /// Parses a plain text file where each line represents a row of space-separated strings.
        /// </summary>
        /// <returns>A two-dimensional array of strings parsed from the file.</returns>
        public string[,] ParseTextFileAsStringGrid()
        {
            return ParseTextFileAsGrid<string>(s => s);
        }


        /// <summary>
        /// Parses a plain text file where each line represents a row of space-separated values,
        /// and converts each value to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which each grid value should be converted.</typeparam>
        /// <param name="converter">A function that converts a string to the target type T.</param>
        /// <returns>A two-dimensional array of type T parsed from the file.</returns>
        public T[,] ParseTextFileAsGrid<T>(Func<string, T> converter)
        {
            var lines = this.ReadAllLines();

            int rows = lines.Length;
            int cols = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            T[,] grid = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = converter(values[j]);
                }
            }

            return grid;
        }


        /// <summary>
        /// Placeholder for parsing a CSV file into a structured format.
        /// </summary>
        /// <remarks>
        /// This method is not implemented yet.
        /// In the future, it might return a list of string arrays or a custom object model.
        /// </remarks>
        public void ParseCsv()
        {
            throw new NotImplementedException("CSV parsing is not implemented yet.");
        }

        /// <summary>
        /// Placeholder for parsing an XML file into a structured format.
        /// </summary>
        /// <remarks>
        /// This method is not implemented yet.
        /// In the future, it could deserialize the XML into objects or read nodes manually.
        /// </remarks>
        public void ParseXml()
        {
            throw new NotImplementedException("XML parsing is not implemented yet.");
        }
    }
}
