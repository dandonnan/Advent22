namespace AdventTests.Puzzles
{
    using Advent.Puzzles;
    using System.Diagnostics.CodeAnalysis;

    // A base class for testing puzzles
    [ExcludeFromCodeCoverage]
    internal class PuzzleTestBase<T>
        where T : IPuzzle, new()
    {
        // The puzzle class instance
        private T puzzle;

        // When starting a test, create a new puzzle instance
        [SetUp]
        public void OnTestStart()
        {
            puzzle = new T();
        }

        // Solve the first puzzle using the data
        // in the given file
        public string SolvePuzzle1(string file)
        {
            return puzzle.SolvePuzzle1(file);
        }

        // Solve the second puzzle using the data
        // in the given file
        public string SolvePuzzle2(string file)
        {
            return puzzle.SolvePuzzle2(file);
        }
    }
}