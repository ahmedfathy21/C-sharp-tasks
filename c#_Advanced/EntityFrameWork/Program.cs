using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EntityFrameWork.Models;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("🚀 Starting Entity Framework MySQL App...\n");

        // Load configuration
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Read and decrypt connection string
        var encryptedConn = builder.GetConnectionString("DefaultConnection");
        // var encryptionsection = builder.GetSection("Encryption");
        var key = builder["Encryption:Key"];
        var connectionString = IsEncrypted(encryptedConn)
            ? DecryptString(encryptedConn, key)
            : encryptedConn;

        // Setup DI container
        var services = new ServiceCollection();
        services.AddDbContext<AppDbContext>(options =>
            options
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .LogTo(Console.WriteLine, LogLevel.Information)
        );

        var serviceProvider = services.BuildServiceProvider();
        var db = serviceProvider.GetRequiredService<AppDbContext>();

        Console.WriteLine("🔧 Ensuring database exists...");
        await db.Database.EnsureCreatedAsync();

        Console.WriteLine("💾 Adding sample wallets...");
        db.Wallets.AddRange(
            new Wallet { Holder = "Ahmad", Balance = 10000 },
            new Wallet { Holder = "Reem", Balance = 5000 }
        );
        await db.SaveChangesAsync();

        Console.WriteLine("\n📊 Current Wallets:");
        foreach (var w in db.Wallets)
            Console.WriteLine($" • ID: {w.Id}, Holder: {w.Holder}, Balance: {w.Balance}");

        Console.WriteLine("\n✅ Done. Press any key to exit...");
        Console.ReadKey();
    }

    // Detect if a string is Base64 (encrypted)
    static bool IsEncrypted(string s)
    {
        try
        {
            Convert.FromBase64String(s);
            return true;
        }
        catch { return false; }
    }

    // AES encryption helper
    public static string EncryptString(string plainText, string key)
    {
        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.GenerateIV();
        using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using var ms = new MemoryStream();
        ms.Write(aes.IV, 0, aes.IV.Length);
        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
        using (var sw = new StreamWriter(cs))
            sw.Write(plainText);
        return Convert.ToBase64String(ms.ToArray());
    }

    // AES decryption helper
    public static string DecryptString(string cipherText, string key)
    {
        var fullCipher = Convert.FromBase64String(cipherText);
        using var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key);
        var iv = new byte[aes.BlockSize / 8];
        var cipher = new byte[fullCipher.Length - iv.Length];
        Array.Copy(fullCipher, iv, iv.Length);
        Array.Copy(fullCipher, iv.Length, cipher, 0, cipher.Length);
        aes.IV = iv;

        using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using var ms = new MemoryStream(cipher);
        using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
        using var sr = new StreamReader(cs);
        return sr.ReadToEnd();
    }
}
