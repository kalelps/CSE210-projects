using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Nephi", 3, 7);
        var text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        var scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
            {
                Console.WriteLine("All words are hidden. Good job! Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("Press Enter to hide words, or type 'quit' and press Enter to exit.");
            var input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
