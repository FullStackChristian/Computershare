using System;
using System.IO;


namespace Computershare
{
    class Program
    {
        static void Main(string[] args)
        {
            FileConverter con = new FileConverter();
            Calculator cal = new Calculator();

            Console.WriteLine("Input and absolut filePath to read a file: ");
            string filePath = Console.ReadLine();
            //string filePath = @"/Users/christian/Desktop/ComputerShareCodingChallenge/ChallengeSampleDataSet1.txt";

            //Check path exists
            Console.WriteLine(File.Exists(filePath) ? "The file is available." : "Check that path is correct.");
            StreamReader reader = new StreamReader(filePath);

            //Read path variablel into string
            string inputFile = reader.ReadToEnd();
            reader.Close();

            //Convert string into float[]
            var converted = con.ConvertingFiles(inputFile);

            Console.WriteLine("Buy and Sell recommendation: ");
            cal.MaxDiff(converted, converted.Length);
        }
    }
}
