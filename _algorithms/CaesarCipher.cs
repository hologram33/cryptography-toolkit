using System.Runtime.CompilerServices;

namespace cryptography_toolkit._algorithms;

// Caesar Cipher

// We have a text. Every letter is shifted by a fixed number of positions down the alphabet.

// The key can be any number 3, 100, -199, ...
// For example, with a shift of 3, A would be replaced by D, B would become E, and so on.

// If the shift reaches the end of the alphabet, it wraps around to the beginning.
// For example, with a shift of 3, X would become A, Y would become B, and Z would become C.

// ASCII values for letters:
// a = 65, b = 66, c = 67, d = 68, e = 69, f = 70, g = 71, h = 72, i = 73, j = 74, k = 75, l = 76, m = 77,
// n = 78, o = 79, p = 80, q = 81, r = 82, s = 83, t = 84, u = 85, v = 86, w = 87, x = 88, y = 89, z = 90

// A = 97, B = 98, C = 99, D = 100, E = 101, F = 102, G = 103, H = 104, I = 105, J = 106, K = 107, L = 108, M = 109,
// N = 110, O = 111, P = 112, Q = 113, R = 114, S = 115, T = 116, U = 117, V = 118, W = 119, X = 120, Y = 121, Z = 122

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