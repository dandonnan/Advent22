namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 2 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle2Tests : PuzzleTestBase<Puzzle2>
    {
        // Test that when the given file is run that
        // it returns the expected number of points
        // from using the specified moves
        [Test]
        [TestCase("day2_sample", ExpectedResult = "15")]
        [TestCase("day2", ExpectedResult = "10624")]
        public string SolveRockPaperScissorsWithDefinedMovesTest(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the expected number of points
        // from using the specified outcomes
        [Test]
        [TestCase("day2_sample", ExpectedResult = "12")]
        [TestCase("day2", ExpectedResult = "14060")]
        public string SolveRockPaperScissorsWithDefinedOutcomesTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}