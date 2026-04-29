using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Encrypt.Helpers;

namespace Encrypt
{
    public partial class EncryptDecryptView : Form
    {
        private bool _isProd;
        public EncryptDecryptView()
        {
            InitializeComponent();
            certifPathTxt.Text = Settings.Default.CertifPath;
        }

        private void ChooseCertifBtn_Click(object sender, EventArgs e)
        {
            var folderChooser = new FolderBrowserDialog { SelectedPath = certifPathTxt.Text };
            if (folderChooser.ShowDialog() == DialogResult.OK)
            {
                certifPathTxt.Text = folderChooser.SelectedPath;
            }
            Settings.Default.CertifPath = folderChooser.SelectedPath;
            Settings.Default.Save();
        }

        private bool PrivateKeyExist => File.Exists(PrivateKeyPath);

        private string PrivateKeyPath => Path.Combine(RootEnvPath, "server.pfx");

        private string PublicKeyPath => Path.Combine(RootEnvPath, "client.crt");

        private string RootEnvPath => Path.Combine(certifPathTxt.Text, _isProd ? "PROD" : "DEV");

        private string CertifPath => PrivateKeyExist ? PrivateKeyPath : PublicKeyPath;

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(encryptTxt.Text) || string.IsNullOrWhiteSpace(certifPathTxt.Text))
            {
                MessageBox.Show(@"A certificate is require to encrypt text");
            }
            
            var certificate = new X509Certificate2(CertifPath);
            var encryptedText = CertificateHelper.Encrypt(certificate, encryptTxt.Text);
            decryptTxt.Text = encryptedText;
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(decryptTxt.Text) || string.IsNullOrWhiteSpace(certifPathTxt.Text))
            {
                return;
            }

            var certificate = new X509Certificate2(CertifPath);
            var decryptedText = CertificateHelper.Decrypt(certificate, decryptTxt.Text);
            if (decryptedText == null)
            {
                MessageBox.Show(@"Impossible to decrypt. Does your cetificate contain a private key ?");
            }
            encryptTxt.Text = decryptedText;
        }

        private void DevProdButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_isProd)
            {
                _isProd = false;
                devProdButton.Text = @"DEV";
                devProdButton.BackColor = Color.Lime;
            }
            else
            {
                _isProd = true;
                devProdButton.Text = @"PROD";
                devProdButton.BackColor = Color.OrangeRed;
            }
        }
    }
}
