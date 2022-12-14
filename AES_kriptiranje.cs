using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OS2_kriptiranje
{
    public class AES_kriptiranje
    {
        AesCryptoServiceProvider aes_servis;
        public AES_kriptiranje()
        {
            aes_servis = new AesCryptoServiceProvider();

            aes_servis.BlockSize = 128;
            aes_servis.KeySize = 256;
            aes_servis.GenerateIV();
            aes_servis.GenerateKey();
            aes_servis.Mode = CipherMode.CBC;
            aes_servis.Padding = PaddingMode.PKCS7;

        }

        public void kreiraj_kljuc(string putanja_datoteke)
        {
            var tajni_kljuc = Convert.ToBase64String(aes_servis.Key);

            File.WriteAllText(putanja_datoteke, tajni_kljuc.ToString());
        }

        public string kriptiranje(string cisti_text)
        {
            ICryptoTransform cryptoTransform = aes_servis.CreateEncryptor();

            byte[] encrypted_bytes = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(cisti_text), 0, cisti_text.Length);

            return Convert.ToBase64String(encrypted_bytes);
        }

        public string dekriptiranje(string dekriptirani_text)
        {
            ICryptoTransform cryptoTransform = aes_servis.CreateDecryptor();

            byte[] encrypted_bytes = Convert.FromBase64String(dekriptirani_text);
            byte[] decrypted_bytes = cryptoTransform.TransformFinalBlock(encrypted_bytes, 0, encrypted_bytes.Length);

            return ASCIIEncoding.ASCII.GetString(decrypted_bytes);
        }
    }
}
