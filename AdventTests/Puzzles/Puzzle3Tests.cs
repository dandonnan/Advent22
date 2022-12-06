namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 3 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle3Tests : PuzzleTestBase<Puzzle3>
    {
        // Test that when the given file is run that
        // it returns the sum of the priority of items
        // that appear in both rucksacks
        [Test]
        [TestCase("day3_sample", ExpectedResult = "157")]
        [TestCase("day3", ExpectedResult = "8018")]
        public string SolveRucksackPriorityTest(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the sum of the priority of all
        // authenticity badges
        [Test]
        [TestCase("day3_sample", ExpectedResult = "70")]
        [TestCase("day3", ExpectedResult = "2518")]
        public string SolveRucksackBadgeTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}