using System.Text;

namespace SolutionCode;

public class CaeserCipher
{
    public static readonly Tuple<char, int> LOWERCASE_A = new Tuple<char, int>('a', (int)'a');
    public static readonly Tuple<char, int> LOWERCASE_Z = new Tuple<char, int>('z', (int)'z');
    
    // Add 1 to alphabet size to account for zero-based index values.
    public static int ALPHABET_SIZE = LOWERCASE_Z.Item2 - LOWERCASE_A.Item2 + 1;

    public static readonly Dictionary<int, char> CHARACTER_INDEX_LOOKUP;
    public static readonly Dictionary<char, int> INDEX_CHARACTER_LOOKUP;

    static CaeserCipher()
    {
        CHARACTER_INDEX_LOOKUP = new Dictionary<int, char>();
        INDEX_CHARACTER_LOOKUP = new Dictionary<char, int>();
        
        int charHashValue = 0;
        
        for (char character = LOWERCASE_A.Item1; character <= LOWERCASE_Z.Item1; ++character)
        {
            CHARACTER_INDEX_LOOKUP.Add(charHashValue, character);
            INDEX_CHARACTER_LOOKUP.Add(character, charHashValue);
            ++charHashValue;
        }
    }
    
    public static string Encrypt(string plaintext, int rotations)
    {
        StringBuilder ciphertextStringBuilder = new StringBuilder();
        
        foreach (var character in plaintext)
        {
            if (!char.IsLetter(character))
                ciphertextStringBuilder.Append(character);
            else if (char.IsUpper(character))
                ciphertextStringBuilder.Append(Char.ToUpper(RotateCharacter(char.ToLower(character), rotations)));
            else
                ciphertextStringBuilder.Append(RotateCharacter(character, rotations));
        }
        
        return ciphertextStringBuilder.ToString();
    }

    public static char RotateCharacter(char character, int rotations)
    {
        int plaintextHashValue = INDEX_CHARACTER_LOOKUP[character];
        int rotatedHashIndex = (plaintextHashValue + rotations) % ALPHABET_SIZE;
        
        // Subtract 1 for 0 based.
        return CHARACTER_INDEX_LOOKUP[rotatedHashIndex];
    }
}