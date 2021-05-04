using System;
namespace Computershare
{
    public class FileConverter
    {
        /// <summary>
        /// Stores string into string array delimited by ',' and converts array of type string to float
        /// </summary>
        /// <param name="unsortedFile"></param>
        /// <returns></returns>
        public float[] ConvertingFiles(string unsortedFile)
        {
            //Read the file into a string array:
            string [] lines =  unsortedFile.Split(",");

            //Convert string array into float array:
            float[] numbers = Array.ConvertAll(lines, s => float.Parse(s));

            return numbers;
        }
    }
}
