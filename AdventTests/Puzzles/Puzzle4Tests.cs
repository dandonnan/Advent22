namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 4 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle4Tests : PuzzleTestBase<Puzzle4>
    {
        // Test that when the given file is run that
        // it returns the number of pairs which contain
        // sections that completely overlap each other
        [Test]
        [TestCase("day4_sample", ExpectedResult = "2")]
        [TestCase("day4", ExpectedResult = "515")]
        public string SolveCompletelyOverlappingPairsTest(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the number of pairs which contain
        // any overlap at all
        [Test]
        [TestCase("day4_sample", ExpectedResult = "4")]
        [TestCase("day4", ExpectedResult = "883")]
        public string SolveAnyOverlappingPairsTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}