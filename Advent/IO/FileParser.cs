namespace Advent.IO
{
    // Parses in files
    internal class FileParser
    {
        // Read an input file and return the contents
        public static string ReadInputFile(string fileName)
        {
            // Set the filepath to the Input directory
            string file = $"Input//{fileName}.txt";

            // Open the file
            using (StreamReader streamReader = new StreamReader(file))
            {
                // Read all of the file and return the contents
                return streamReader.ReadToEnd();
            }
        }

        // Read an input file and return the contents as a list of lines
        public static List<string> ReadInputFileAsLines(string fileName)
        {
            // Create an empty list of lines
            List<string> lines = new List<string>();

            // Set the filepath to the Input directory
            string file = $"Input//{fileName}.txt";

            // Open the file
            using (StreamReader streamReader = new StreamReader(file))
            {
                // As long as the end of the file is not reached
                while (streamReader.EndOfStream == false)
                {
                    // Read a line and add it to the list
                    lines.Add(streamReader.ReadLine());
                }
            }

            // Return the list of lines
            return lines;
        }
    }
}