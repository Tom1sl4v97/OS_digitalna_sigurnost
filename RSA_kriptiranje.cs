using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OS2_kriptiranje
{
    public class RSA_kriptiranje
    {
        private static RSACryptoServiceProvider servis_RSA = new RSACryptoServiceProvider(2048);
        private RSAParameters _privatni_kljuc;
        private RSAParameters _javni_kljuc;

        public RSA_kriptiranje()
        {
            _privatni_kljuc = servis_RSA.ExportParameters(true);
            _javni_kljuc = servis_RSA.ExportParameters(false);
        }

        public void kreiraj_kljuceve(string putanja_javnog_kljuca, string putanja_privatnog_kljuca)
        {
            var string_writer = new StringWriter();
            var xml_serializer = new XmlSerializer(typeof(RSAParameters));
            xml_serializer.Serialize(string_writer, _javni_kljuc);
            File.WriteAllText(putanja_javnog_kljuca, string_writer.ToString());

            xml_serializer.Serialize(string_writer, _privatni_kljuc);
            File.WriteAllText(putanja_privatnog_kljuca, string_writer.ToString());
        }

        public string Kriptiranje(string cisti_text)
        {
            servis_RSA = new RSACryptoServiceProvider();
            servis_RSA.ImportParameters(_javni_kljuc);

            var data = Encoding.Unicode.GetBytes(cisti_text);
            var cypher = servis_RSA.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string Dekriptiranje(string kriptirani_text)
        {
            var dataBytes = Convert.FromBase64String(kriptirani_text);
            servis_RSA.ImportParameters(_privatni_kljuc);
            var cisti_text = servis_RSA.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(cisti_text);
        }

        public string Digitalni_potpis(string hash)
        {
            servis_RSA.ImportParameters(_privatni_kljuc);

            var rsaFormatter = new RSAPKCS1SignatureFormatter(servis_RSA);
            rsaFormatter.SetHashAlgorithm("SHA512");

            return Convert.ToBase64String(rsaFormatter.CreateSignature(Convert.FromBase64String(hash)));
        }

        public Boolean Provjera_digitalnog_potpisa(string putanja_digitalnog_potpisa, string putanja_sazetka_poruke)
        {
            string sazetak = dohvati_sazetak(putanja_sazetka_poruke);
            string digitalni_potpis = dohvati_digitalni_potpis(putanja_digitalnog_potpisa);

            byte[] bytesToVerify = Convert.FromBase64String(sazetak);
            byte[] signedBytes = Convert.FromBase64String(digitalni_potpis);

            servis_RSA.ImportParameters(_javni_kljuc);

            var rsaDeformatter = new RSAPKCS1SignatureDeformatter(servis_RSA);
            rsaDeformatter.SetHashAlgorithm("SHA512");

            return rsaDeformatter.VerifySignature(bytesToVerify, signedBytes);
        }

        private string dohvati_digitalni_potpis(string putanja_digitalnog_potpisa)
        {
            string digitalni_potpis = File.ReadAllText(putanja_digitalnog_potpisa);

            return digitalni_potpis;
        }

        private string dohvati_sazetak(string putanja_sazetka_poruke)
        {
            string sazetak = File.ReadAllText(putanja_sazetka_poruke);

            return sazetak;
        }


    }
}
