# EN
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

# ES

## Biblioteca de Encriptación

La biblioteca de encriptación (`AesEncryptor`) proporciona métodos para realizar encriptación y desencriptación AES. Demuestra cómo configurar adecuadamente ajustes AES, generar un Vector de Inicialización (IV) y realizar operaciones de encriptación y desencriptación usando una clave proporcionada.

### Uso

Para utilizar la biblioteca `AesEncryptor` en tus propios proyectos, sigue estos pasos:

1. Agrega una referencia a la librería `EncryptionLibrary` en tu proyecto.
2. Crea una instancia de la clase `AesEncryptor`:

```csharp
var encryptor = new AesEncryptor();
```

3. Carga la clave secreta desde tu archivo de configuración (por ejemplo, `appsettings.json`):

```csharp
IConfiguration configuration = new ConfigurationBuilder()
   .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("appsettings.json")
   .Build();

string secretKey = configuration.GetSection("AppSettings")["EncryptionKey"];
```

Asegúrate de que tu `appsettings.json` contenga la configuración necesaria:

```json
{
  "AppSettings": {
    "EncryptionKey": "!YouWillLoveComplex256BitSecret!"
  }
}
```

Para encriptar datos, utiliza el método `EncryptAES`:

```csharp
string plainText = "Datos sensibles para encriptar";

byte[] encryptedData = encryptor.EncryptAES(plainText, secretKey);
```

Para desencriptar datos, utiliza el método `DecryptAES`:

```csharp
byte[] encryptedData = /* Recupera los datos encriptados */;
string decryptedText = encryptor.DecryptAES(encryptedData, secretKey);
```

Recuerda reemplazar `"EncryptionKey"` en el archivo `appsettings.json` con tu clave de encriptación real.

La biblioteca de encriptación proporciona una forma conveniente de incorporar funcionalidad segura de encriptación y desencriptación de datos en tus aplicaciones.

## Programa de Ejemplo

El programa de ejemplo (`Program.cs`) demuestra cómo usar la biblioteca de encriptación. Carga una clave secreta desde la configuración, encripta y desencripta datos usando la biblioteca, y muestra los resultados.

### Contribuciones

Las contribuciones para mejorar y realzar la biblioteca de encriptación son bienvenidas. Si encuentras algún problema o tienes sugerencias para mejoras, no dudes en abrir un problema o enviar un pull request.

### Licencia

Este proyecto está bajo la [Licencia MIT](LICENSE).

