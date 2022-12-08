namespace AdventTests.Puzzles
{
    using System.Diagnostics.CodeAnalysis;
    using Advent.Puzzles;

    // Tests for Day 6 puzzles
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal class Puzzle6Tests : PuzzleTestBase<Puzzle6>
    {
        // Test that when the given file is run that
        // it returns the index of the start of a message
        // when the message is preceeded by 4 unique
        // characters
        [Test]
        [TestCase("day6_sample1", ExpectedResult = "7")]
        [TestCase("day6_sample2", ExpectedResult = "5")]
        [TestCase("day6_sample3", ExpectedResult = "6")]
        [TestCase("day6_sample4", ExpectedResult = "10")]
        [TestCase("day6_sample5", ExpectedResult = "11")]
        [TestCase("day6", ExpectedResult = "1566")]
        public string SolveFourUniqueCharactersTest(string file)
        {
            return base.SolvePuzzle1(file);
        }

        // Test that when the given file is run that
        // it returns the index of the start of a message
        // when the message is preceeded by 14 unique
        // characters
        [Test]
        [TestCase("day6_sample1", ExpectedResult = "19")]
        [TestCase("day6_sample2", ExpectedResult = "23")]
        [TestCase("day6_sample3", ExpectedResult = "23")]
        [TestCase("day6_sample4", ExpectedResult = "29")]
        [TestCase("day6_sample5", ExpectedResult = "26")]
        [TestCase("day6", ExpectedResult = "2265")]
        public string SolveFourteenUniqueCharactersTest(string file)
        {
            return base.SolvePuzzle2(file);
        }
    }
}