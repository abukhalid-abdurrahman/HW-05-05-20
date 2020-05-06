using System;

namespace Day_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineSeperator = new string('*', 45);
            Console.WriteLine("List example:");
            MyList<string> names = new MyList<string>();
            names.Add("Faridun");
            names.Add("Mijgona");
            names.Add("Firuz");
            names.Add("Avaz");
            names.Add("Mehrdod");
            names.Add("Ravshan");
            Console.WriteLine($"{names.Count} elements was added!");
            Console.WriteLine("Elements: ");
            foreach(var name in names)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine($"\n{lineSeperator}");
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            Console.WriteLine("Dictionary example:");
            dictionary.Add("you", "ты");
            dictionary.Add("we", "мы");
            dictionary.Add("us", "нас");
            dictionary.Add("they", "они");
            dictionary.Add("it", "оно");
            dictionary.Add("our", "наш");
            dictionary.Add("my", "мой");
            dictionary.Add("your", "твой");
            Console.WriteLine("Dictionary have words: you, we, us, they, it, our, my, your that translated into russian language. Some of them: ");
            Console.WriteLine("you - " + dictionary["you"]);
            Console.WriteLine("they - " + dictionary["they"]);
            Console.WriteLine("your - " + dictionary["your"]);
            Console.WriteLine("it - " + dictionary["it"]);

            Console.WriteLine("All words of dictionary:");
            foreach(var item in dictionary)
            {
                Console.WriteLine(item + " - " + dictionary[item.ToString()]);
            }

            Console.Read();
        }
    }
}
