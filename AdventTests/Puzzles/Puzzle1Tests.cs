namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 1 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle1Tests : PuzzleTestBase<Puzzle1>
    {
        // Test that when the given file is run that
        // it returns the expected highest number of
        // calories
        [Test]
        [TestCase("day1_sample", ExpectedResult = "24000")]
        [TestCase("day1", ExpectedResult = "66719")]
        public string SolveHighestCalorieTotalTests(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the expected top 3 highest
        // number of calories
        [Test]
        [TestCase("day1_sample", ExpectedResult = "45000")]
        [TestCase("day1", ExpectedResult = "198551")]
        public string SolveHighestThreeCalorieTotalsTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}