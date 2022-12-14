using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OS2_kriptiranje
{
    public partial class kriptiranje_form : Form
    {
        RSA_kriptiranje rsa = new RSA_kriptiranje();
        AES_kriptiranje aes = new AES_kriptiranje();

        //POTREBNO JE PROMIJENITI PUTANJU DO DATOTEKE AKO SE PROGRAM POZIVA IZ NOVOG RAČUNALA
        string putanja = @"C:\Faks\DIPLOMSKI_STUDIJ\7 SEMESTAR\OS2\Projekt\OS2_kriptiranje\Datoteke";

        string putanja_cistog_texta = @"\Uneseni_text.txt";
        string putanja_kriptiranog_RSA_texta = @"\Kriptirani_RSA_text.txt";
        string putanja_kriptiranog_AES_texta = @"\Kriptirani_AES_text.txt";
        string putanja_sazetka_poruke = @"\Sazetak_poruke.txt";
        string putanja_digitalnog_potpisa = @"\Digitalni_potpis.txt";
        
        string putanja_tajnog_kljuca = @"\Tajni_kljuc.txt";
        string putanja_javnog_kljuca = @"\Javni_kljuc.txt";
        string putanja_privatnog_kljuca = @"\Privatni_kljuc.txt";

        public kriptiranje_form()
        {
            InitializeComponent();
        }

        private void pohrani_text_btn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putanja + putanja_cistog_texta, text_tbx.Text);
        }

        private void stvori_kljuceve_btn_Click(object sender, EventArgs e)
        {
            aes.kreiraj_kljuc(putanja + putanja_tajnog_kljuca);
            rsa.kreiraj_kljuceve(putanja + putanja_javnog_kljuca, putanja + putanja_privatnog_kljuca);
        }

        private void Kriptiraj_rsa_btn_Click(object sender, EventArgs e)
        {
            string cisti_text = File.ReadAllText(putanja + putanja_cistog_texta);
            string kriptirani_text = rsa.Kriptiranje(cisti_text);

            File.WriteAllText(putanja + putanja_kriptiranog_RSA_texta, kriptirani_text);

            text_tbx.Text = kriptirani_text;
        }

        private void Dekriptiraj_rsa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string kriptirani_RSA_text = File.ReadAllText(putanja + putanja_kriptiranog_RSA_texta);
                string dekriptirani_text = rsa.Dekriptiranje(kriptirani_RSA_text);

                text_tbx.Text = dekriptirani_text;
            }
            catch (Exception)
            {
                neocekivana_pogreska();
            }
            
        }

        private void Kriptiraj_aes_btn_Click(object sender, EventArgs e)
        {
            string cisti_text = File.ReadAllText(putanja + putanja_cistog_texta);
            string kriptirani_text = aes.kriptiranje(cisti_text);

            File.WriteAllText(putanja + putanja_kriptiranog_AES_texta, kriptirani_text);

            text_tbx.Text = kriptirani_text;
        }

        private void Dekriptiraj_aes_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string kriptirani_AES_text = File.ReadAllText(putanja + putanja_kriptiranog_AES_texta);
                string dekriptirani_text = aes.dekriptiranje(kriptirani_AES_text);

                text_tbx.Text = dekriptirani_text;
            }
            catch (Exception)
            {
                neocekivana_pogreska();
            }
            
        }

        private void sazetak_btn_Click(object sender, EventArgs e)
        {
            string cisti_text = File.ReadAllText(putanja + putanja_cistog_texta);
            string sazetak_poruke = izracun_hasha_sha512(cisti_text);

            File.WriteAllText(putanja + putanja_sazetka_poruke, sazetak_poruke);

            text_tbx.Text = sazetak_poruke;
        }

        private string izracun_hasha_sha512(string text)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(text);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hash_texta = hash.ComputeHash(bytes);

                return Convert.ToBase64String(hash_texta);
            }
        }

        private void digitalni_potpis_btn_Click(object sender, EventArgs e)
        {
            string hash = File.ReadAllText(putanja + putanja_sazetka_poruke);
            string digitalni_potpis = rsa.Digitalni_potpis(hash);

            File.WriteAllText(putanja + putanja_digitalnog_potpisa, digitalni_potpis);
            text_tbx.Text = digitalni_potpis;
        }

        private void provjeri_digitalni_potpis_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string kriptirani_AES_text = File.ReadAllText(putanja + putanja_kriptiranog_AES_texta);
                string dekriptirani_text = aes.dekriptiranje(kriptirani_AES_text);

                text_tbx.Text = dekriptirani_text;
            }
            catch (Exception)
            {
                neocekivana_pogreska();
            }
            MessageBox.Show(poruka_provjere_digitalnog_potpisa(), "Neočekivana pogreška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private string poruka_provjere_digitalnog_potpisa()
        {
            string digitalnog_potpisa = putanja + putanja_digitalnog_potpisa;
            string sazetka_poruke = putanja + putanja_sazetka_poruke;
            if (rsa.Provjera_digitalnog_potpisa(digitalnog_potpisa, sazetka_poruke))
            {
                return "Digitalni potpis je u redu";
            }
            return "Digitalni potpis nije u redu, došlo je do promjene sažetka";
        }

        private void neocekivana_pogreska()
        {
            MessageBox.Show("Došlo je do promjene ključa ili poruke", "Neočekivana pogreška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
