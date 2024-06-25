internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<char, string> dictionary = new Dictionary<char, string>();

        dictionary['a'] = "Bonjour";

        dictionary['b'] = " le";

        dictionary['c'] = " monde";
        dictionary.Remove('c');
    }
}