using SolutionCode;

namespace xUnitTests;

public class CaeserCipherTests
{
    [Fact]
    public void TestAandZIntegerValues()
    {
        Assert.Equal(97, CaeserCipher.LOWERCASE_A.Item2);
        Assert.Equal(122, CaeserCipher.LOWERCASE_Z.Item2);
    }
    
    [Fact]
    public void TestShiftedAlphabetByPlus3()
    {
        var plainText = "abcdefghijklmnopqrstuvwxyz";
        var expectedCipherText = "defghijklmnopqrstuvwxyzabc";
        
        Assert.Equal(expectedCipherText, CaeserCipher.Encrypt(plainText, 3));
    }
    
    
    [Theory]
    [InlineData('a', 'b')]
    [InlineData('j', 'k')]
    [InlineData('z', 'a')]
    public void TestShiftedAlphabetByPlus1(char plaintextCharacter, char ciphertextCharacter)
    {
        Assert.Equal(ciphertextCharacter, CaeserCipher.RotateCharacter(plaintextCharacter, 1));
    }
    
    [Theory]
    [InlineData("There's-a-starman-waiting-in-the-sky", "Wkhuh'v-d-vwdupdq-zdlwlqj-lq-wkh-vnb",3)]
    [InlineData("middle-Outz", "okffng-Qwvb", 2)]
    [InlineData("Always-Look-on-the-Bright-Side-of-Life", "Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj", 5)]
    public void HackerrankTests(string plaintext, string expectedCiphertext, int rotations)
    {
        Assert.Equal(expectedCiphertext, CaeserCipher.Encrypt(plaintext, rotations));
    }
    
    [Theory]
    [InlineData("159357lcfd", "159357fwzx",98)]
    public void FailingHackerrankTests(string plaintext, string expectedCiphertext, int rotations)
    {
        Assert.Equal(expectedCiphertext, CaeserCipher.Encrypt(plaintext, rotations));
    }
}