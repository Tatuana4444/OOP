using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;


namespace Plug
{
    public class Crypto
    {
        private byte[] aeskey;
        private byte[] aesiv;
        public byte[] AesKey
        {
            get { return aeskey; } 
        }
        public byte[] AesIV
        {
            get { return aesiv; }
        }
        public string Decrypt(byte[] Text)
        {
            byte[] cipherText = new byte[Text.Length - 48];
            byte[] key = new byte[32];
            byte[] iv = new byte[16];
            int i, j;
            for (i = 0; i < cipherText.Length; i++)
                cipherText[i] = Text[i];
            for (j = 0; j < 32; i++, j++)
                key[j] = Text[i];
            for (j = 0; j < 16; i++, j++)
                iv[j] = Text[i];

            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Padding = PaddingMode.None;
                aesAlg.Key = key;
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return plaintext;
        }
        public byte[] Encrypt(string plainText)
        {
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateIV();
                aeskey = aesAlg.Key;
                aesiv= aesAlg.IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }

                return encrypted;
            }
           

        }
        public void CompressFile(string FilePath)
        {
            int k = FilePath.IndexOf(".");
            string ZGPath = FilePath.Substring(0, k)+".gz" ;
            Compress(FilePath, ZGPath);

        }
        private void Compress(string sourceFile, string compressedFile)
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        public void ExtractFile(string ZGPath)
        {
            int i= ZGPath.Length;
            int k = ZGPath.IndexOf(".");
            string FilePath = ZGPath.Substring(0, k) + "_.bin";
            Decompress(ZGPath, FilePath);
        }
        public static void Decompress(string compressedFile, string targetFile)
        {
            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(targetFile))
                {
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }
        public void CompressDirectory(string DirectoryPath)
        {
            int i = DirectoryPath.Length-1;
            while (DirectoryPath[i--]!='\\') ;
            string zipPath = DirectoryPath+".zip";
            ZipFile.CreateFromDirectory(DirectoryPath, zipPath);
        }
        public void ExtractDirectory(string zipPath)
        {
            int k = zipPath.IndexOf(".");
            string DirectoryPath = zipPath.Substring(0, k) + "2";
            ZipFile.ExtractToDirectory(zipPath, DirectoryPath);

        }

    }
}
