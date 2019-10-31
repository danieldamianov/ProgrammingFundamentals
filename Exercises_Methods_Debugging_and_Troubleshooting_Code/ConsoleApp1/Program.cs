using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            string matchedString = "";
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump;

                if (i + endIndex >= text.Length)
                {
                    matchedString = text.Substring(i);
                }
                else
                matchedString = text.Substring(i, endIndex + 1);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
