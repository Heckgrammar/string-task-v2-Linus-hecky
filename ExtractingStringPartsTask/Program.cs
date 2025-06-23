using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            int lenght = state.Length;
            Console.WriteLine(lenght);
            string cityLandmark = (city + " " + landmark);
            Console.WriteLine(cityLandmark);
            Console.WriteLine(country[0]);
            Console.WriteLine($"{city[0]}{city[city.Length - 1]}");
            int start = landmark.IndexOf('c');
      Console.WriteLine(landmark.Substring(start));
      start = country.IndexOf('S');
      int end = country.IndexOf('A');
      Console.WriteLine(country.Substring(end - start));
      Console.WriteLine(state.IndexOf('f') + 1);


      string vowels = "aeiouAEIOU";
      int vowelCount = country.Count(c => vowels.Contains(c));
      Console.WriteLine($"{country} has {vowelCount} vowels");
      vowelCount = state.Count(c => vowels.Contains(c));
      Console.WriteLine($"{state} has {vowelCount} vowels");
      vowelCount = landmark.Count(c => vowels.Contains(c));
      Console.WriteLine($"{landmark} has {vowelCount} vowels");
      vowelCount = city.Count(c => vowels.Contains(c));
      Console.WriteLine($"{city} has {vowelCount} vowels");


      // output the length of state

      // Concatenate the contents of city and landmark * don't forget to add a space

      // output the first character of county

      // output a concatenation of the first and last characters of city

      // output the substring of landmark starting at c and outputting to the end

      // output the substring of country starting at the first S and ending at the first A

      // output the position of f in California

      //************CHALLENGE****************//
      // Output how many vowels are in each of the strings in the format
      // California has n vowels




      // Show your evidence of the program running in the Readme file
    }
    }
}
