namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 5 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle5Tests : PuzzleTestBase<Puzzle5>
    {
        // Test that when the given file is run that
        // it returns the crates which are on top
        // of each stack when crates are moved one
        // at a time
        [Test]
        [TestCase("day5_sample", ExpectedResult = "CMZ")]
        [TestCase("day5", ExpectedResult = "SBPQRSCDF")]
        public string SolveTopOfEachStackOneAtATimeTest(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the crates that are on top of
        // each stack when multiple crates are moved
        // at once
        [Test]
        [TestCase("day5_sample", ExpectedResult = "MCD")]
        [TestCase("day5", ExpectedResult = "RGLVRCQSB")]
        public string SolveTopOfEachStackMultipleAtOnceTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}