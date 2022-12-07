using Advent.Puzzles;

const string solution = "The solution to the {0} puzzle is {1}.";

// Startup a puzzle
IPuzzle puzzle = new Puzzle5();

// Set the name of the file to load
string file = "day5";

// Solve the puzzles and output the solution
Console.WriteLine(string.Format(solution, "first", puzzle.SolvePuzzle1(file)));
Console.WriteLine(string.Format(solution, "second", puzzle.SolvePuzzle2(file)));