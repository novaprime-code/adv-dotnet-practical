using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("################  ADV. .NET Lab Practical  ################");
        Console.WriteLine("##############  File I/O Ops  ##############\n");
        try
        {
            // Specify the path to the text file
            string filePath = "input.txt";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }

            // Read all lines from the text file
            string[] lines = File.ReadAllLines(filePath);

            // Display the content of the file
            Console.WriteLine("Content of the text file:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified directory was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to access the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has finished executing.");
            Console.ReadKey();
        }
    }
}
