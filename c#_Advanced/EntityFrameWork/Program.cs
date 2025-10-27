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
    /// <summary>
    /// Main entry point for the application. Initializes the configuration, database context,
    /// and demonstrates basic database operations with Entity Framework Core using MySQL.
    /// </summary>
    /// <param name="args">An array of command line arguments passed to the application.</param>
    /// <returns>A Task representing the asynchronous operation of the Main method.</returns>
    static async Task Main(string[] args)
    {
        Console.WriteLine("🚀 Starting Entity Framework MySQL App...\n");


        // setup the configuration and read the Json file
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

        // Get the database context from the DI container and run some queries
        var serviceProvider = services.BuildServiceProvider();
        var db = serviceProvider.GetRequiredService<AppDbContext>();

        Console.WriteLine("🔧 Ensuring database exists...");
        await db.Database.EnsureCreatedAsync();

        Console.WriteLine("💾 Adding sample wallets...");
        // db.Wallets.AddRange(
        //     new Wallet { Holder = "Ahmad", Balance = 10000 },
        //     new Wallet { Holder = "Reem", Balance = 5000 }
        // );
        // await db.SaveChangesAsync();
        var holder = "Ali";
        var balance = 5000m;

        await db.Database.ExecuteSqlRawAsync("CALL AddWallet({0}, {1})","Ali", 400);
        Console.WriteLine($"✅ Wallet for {holder} added successfully!");

        
        Console.WriteLine("\n📞 Calling stored procedure...");
         var wallets = await db.Wallets
            .FromSqlRaw("CALL GetAllWallets()")
            .ToListAsync();
        
        foreach (var wallet in wallets) 
            Console.WriteLine(wallet);
        
        // Console.WriteLine("\n📊 Current Wallets (using await foreach):");
        // await foreach (var wallet in db.Wallets)
        // {
        //     Console.WriteLine($"Holder: {wallet.Holder}");
        //     Console.WriteLine($"Balance: {wallet.Balance}");
        //     Console.WriteLine($" • ID: {wallet.Id}, Holder: {wallet.Holder}, Balance: {wallet.Balance}");
        // }

        Console.WriteLine("\n📊 Current Wallets:");

        static bool IsEncrypted(string s)
        {
            try
            {
                Convert.FromBase64String(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
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
