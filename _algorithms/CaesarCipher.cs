using System.Runtime.CompilerServices;

namespace cryptography_toolkit._algorithms;

public static class CaesarCipher
{
    public static string Encrypt(string text, int key)
    {
        return Shift(text, key);
    }

    public static string Decrypt(string text, int key)
    {
        return Shift(text, -key);
    }

    private static string Shift(string text, int key)
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

                int offset = (((c - start) + key) % 26 + 26) % 26;
                result[i] = (char)(offset + start);
            }
            else
            {
                result[i] = c;
            }   
        }
        return new string(result);
    }
}