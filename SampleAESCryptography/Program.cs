using EncryptionLibrary;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        // Load configuration from appsettings.json
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Retrieve the secret key from the configuration
        string secretKey = configuration.GetSection("AppSettings")["EncryptionKey"];

        // Plain text to be encrypted
        string plaintext = "Sensitive data to encrypt";

        // Initialize the AES encryptor
        var encryptor = new AesEncryptor();

        // Encrypt the plain text using the secret key
        byte[] encryptedBytes = encryptor.EncryptAES(plaintext, secretKey);
        Console.WriteLine("Encrypted Data: " + Convert.ToBase64String(encryptedBytes));

        // Decrypt the encrypted bytes using the secret key
        string decryptedText = encryptor.DecryptAES(encryptedBytes, secretKey);
        Console.WriteLine("Decrypted Data: " + decryptedText);
    }
}