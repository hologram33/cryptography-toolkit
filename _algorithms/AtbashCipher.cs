using System.Runtime.CompilerServices;

namespace cryptography_toolkit._algorithms;

public static class AtbashCipher
{
    public static string Transform(string text)
    {
        return Swap(text);
    }

    private static string Swap(string text)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if(char.IsLetter(c))
            {
                char start;

                if(char.IsUpper(c))
                {
                    start = 'A';
                }
                else
                {
                    start = 'a';
                }

                int position = c - start;
                int reversedPosition = 25 - position;

                result[i] = (char)(start + reversedPosition);
            }
            else
            {
                result[i] = c;
            }   
        }
        return new string(result);
    }
}