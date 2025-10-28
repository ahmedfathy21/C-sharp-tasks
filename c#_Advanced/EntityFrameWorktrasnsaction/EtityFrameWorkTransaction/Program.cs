using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EntityFrameWork.Models;

namespace EntityFrameWorkTransaction
{


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
            Console.WriteLine("Strating the program");
           // First get the connection string from the appsettings.json file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Appsettings.json",optional: false , reloadOnChange:true)
                .Build();
            var constr = builder.GetConnectionString("DefaultConnection");
            var Encryptedstr = EncryptString(constr, builder["Encryption:Key"]);
            
            // Go for the encryption and check the connection string
            var key = builder["Encryption:Key"];
            Encryptedstr = IsEncrypted(constr)? DecryptString(constr,key) : constr;
            Console.WriteLine($"The connection string is {Encryptedstr}");
            
            // Setup DI container
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(Encryptedstr, ServerVersion.AutoDetect(Encryptedstr))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                    .LogTo(Console.WriteLine, LogLevel.Information));
            var serviceProvider = services.BuildServiceProvider();
            var db = serviceProvider.GetRequiredService<AppDbContext>();
            
            db.Database.EnsureCreated();
            Console.WriteLine("Database created successfully");
            
            var listedaccounts = db.Wallets.FromSqlRaw("CALL GetAllWallets()").ToList();
            foreach (var item in listedaccounts)
            Console.WriteLine(item);
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                var fromwallet = db.Wallets.Find(1);
                var towallet = db.Wallets.Find(2);
                fromwallet.Balance -= 100;
                towallet.Balance += 100;
                await db.SaveChangesAsync();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                listedaccounts = await db.Wallets.FromSqlRaw("CALL GetAllWallets()").ToListAsync();
                Console.WriteLine("Transaction completed");
                foreach (var VARIABLE in listedaccounts)
                {
                    Console.WriteLine(VARIABLE);
                }
            }
        }

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
}
