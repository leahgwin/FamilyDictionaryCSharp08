using System;
using System.Collections.Generic;


namespace family_dictionary
{
    class Program
    {
        //Define a Dictionary that contains information about several members of your family. Use the following example as a template.
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Ansley"},
            {"age", "21"},
            {"pronoun", "she"}
            });
            myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Davina"},
            {"age", "52"},
            {"pronoun", "she"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Vern"},
            {"age", "52"},
            {"pronoun", "he"}

            });
            myFamily.Add("fiance", new Dictionary<string, string>(){
            {"name", "Benjamin"},
            {"age", "26"},
            {"pronoun", "he"}
            });
            myFamily.Add("dog", new Dictionary<string, string>(){
            {"name", "Harper"},
            {"age", "1.5"},
            {"pronoun", "she"}
            });

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key}, and {member.Value["pronoun"]} is {member.Value["age"]} years old.");
            };
        }

    }
}
