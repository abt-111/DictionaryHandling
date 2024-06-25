internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<char, string> dictionary = new Dictionary<char, string>();

        dictionary['a'] = "Bonjour";

        dictionary['b'] = " le";

        dictionary['c'] = " monde";

        DisplayDictionnary(dictionary);
        dictionary.Remove('c');
        DisplayDictionnary(dictionary);
    }

    public static void DisplayDictionnary(Dictionary<char, string> dictionary)
    {
        foreach (KeyValuePair<char, string> s in dictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", s.Key, s.Value);
        }
        Console.WriteLine();
    }
}