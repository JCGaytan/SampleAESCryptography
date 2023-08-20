## Encryption Library

The encryption library (`AesEncryptor`) provides methods to perform AES encryption and decryption. It demonstrates how to properly configure AES settings, generate an Initialization Vector (IV), and perform encryption and decryption operations using a provided key.

### Usage

To use the `AesEncryptor` library in your own projects, follow these steps:

1. Add a reference to the `EncryptionLibrary` assembly in your project.
2. Create an instance of the `AesEncryptor` class:

```csharp
var encryptor = new AesEncryptor();
```

3. Load the secret key from your configuration file (e.g., `appsettings.json`):

```csharp
IConfiguration configuration = new ConfigurationBuilder()
   .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("appsettings.json")
   .Build();

string secretKey = configuration.GetSection("AppSettings")["EncryptionKey"];
```

Make sure your `appsettings.json` contains the necessary configuration:

```json
{
  "AppSettings": {
    "EncryptionKey": "!YouWillLoveComplex256BitSecret!"
  }
}
```

To encrypt data, use the `EncryptAES` method:

```csharp
string plainText = "Sensitive data to encrypt";

byte[] encryptedData = encryptor.EncryptAES(plainText, secretKey);
```

To decrypt data, use the `DecryptAES` method:

```csharp
byte[] encryptedData = /* Retrieve encrypted data */;
string decryptedText = encryptor.DecryptAES(encryptedData, secretKey);
```

Remember to replace `"EncryptionKey"` on the `appsettings.json` with your actual encryption key.

The encryption library provides a convenient way to incorporate secure data encryption and decryption functionality into your applications.

## Example Program

The example program (`Program.cs`) demonstrates how to use the encryption library. It loads a secret key from the configuration, encrypts and decrypts data using the library, and displays the results.

### Contributing

Contributions to improve and enhance the encryption library are welcome. If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

### License

This project is licensed under the [MIT License](LICENSE).
