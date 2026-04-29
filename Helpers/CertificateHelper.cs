using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Encrypt.Helpers
{
    public static class CertificateHelper
    {
        public static string Encrypt(X509Certificate2 certificate, string stringToEncrypt)
        {
            if (certificate == null || string.IsNullOrEmpty(stringToEncrypt))
            {
                return null;
            }
            var rsa = certificate.GetRSAPublicKey();
            var bytesToEncrypt = Encoding.UTF8.GetBytes(stringToEncrypt);
            var encryptedBytes = rsa.Encrypt(bytesToEncrypt, RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(X509Certificate2 certificate, string stringTodecrypt)
        {
            if (certificate == null || string.IsNullOrEmpty(stringTodecrypt))
            {
                return null;
            }

            if (!certificate.HasPrivateKey)
            {
                return null;
            }

            var rsa = certificate.GetRSAPrivateKey();
            var bytesToDecrypt = Convert.FromBase64String(stringTodecrypt);
            var decryptedBytes = rsa.Decrypt(bytesToDecrypt, RSAEncryptionPadding.Pkcs1);
            var encoder = new UTF8Encoding();
            return encoder.GetString(decryptedBytes);
        }
    }
}
