namespace Advent.Puzzles
{
    // Interface for a puzzle
    internal interface IPuzzle
    {
        // Solve the first puzzle of the day
        string SolvePuzzle1(string file);

        // Solve the second puzzle of the day
        string SolvePuzzle2(string file);
    }
}