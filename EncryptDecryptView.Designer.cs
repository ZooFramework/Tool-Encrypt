namespace Encrypt
{
    partial class EncryptDecryptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.certifPathTxt = new System.Windows.Forms.TextBox();
            this.decryptTxt = new System.Windows.Forms.TextBox();
            this.encryptTxt = new System.Windows.Forms.TextBox();
            this.chooseCertifBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.devProdButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificate path";
            // 
            // certifPathTxt
            // 
            this.certifPathTxt.Location = new System.Drawing.Point(12, 25);
            this.certifPathTxt.Name = "certifPathTxt";
            this.certifPathTxt.ReadOnly = true;
            this.certifPathTxt.Size = new System.Drawing.Size(710, 20);
            this.certifPathTxt.TabIndex = 1;
            // 
            // decryptTxt
            // 
            this.decryptTxt.Location = new System.Drawing.Point(372, 104);
            this.decryptTxt.Multiline = true;
            this.decryptTxt.Name = "decryptTxt";
            this.decryptTxt.Size = new System.Drawing.Size(416, 334);
            this.decryptTxt.TabIndex = 2;
            // 
            // encryptTxt
            // 
            this.encryptTxt.Location = new System.Drawing.Point(12, 104);
            this.encryptTxt.Multiline = true;
            this.encryptTxt.Name = "encryptTxt";
            this.encryptTxt.Size = new System.Drawing.Size(354, 334);
            this.encryptTxt.TabIndex = 3;
            // 
            // chooseCertifBtn
            // 
            this.chooseCertifBtn.Location = new System.Drawing.Point(728, 25);
            this.chooseCertifBtn.Name = "chooseCertifBtn";
            this.chooseCertifBtn.Size = new System.Drawing.Size(60, 20);
            this.chooseCertifBtn.TabIndex = 4;
            this.chooseCertifBtn.Text = "...";
            this.chooseCertifBtn.UseVisualStyleBackColor = true;
            this.chooseCertifBtn.Click += new System.EventHandler(this.ChooseCertifBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(12, 67);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(60, 31);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(728, 67);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(60, 31);
            this.decryptBtn.TabIndex = 6;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // devProdButton
            // 
            this.devProdButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.devProdButton.AutoSize = true;
            this.devProdButton.BackColor = System.Drawing.Color.Lime;
            this.devProdButton.Location = new System.Drawing.Point(170, 71);
            this.devProdButton.Name = "devProdButton";
            this.devProdButton.Size = new System.Drawing.Size(39, 23);
            this.devProdButton.TabIndex = 7;
            this.devProdButton.Text = "DEV";
            this.devProdButton.UseVisualStyleBackColor = false;
            this.devProdButton.CheckedChanged += new System.EventHandler(this.DevProdButton_CheckedChanged);
            // 
            // EncryptDecryptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.devProdButton);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.chooseCertifBtn);
            this.Controls.Add(this.encryptTxt);
            this.Controls.Add(this.decryptTxt);
            this.Controls.Add(this.certifPathTxt);
            this.Controls.Add(this.label1);
            this.Name = "EncryptDecryptView";
            this.Text = "Encrypt / Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox certifPathTxt;
        private System.Windows.Forms.TextBox decryptTxt;
        private System.Windows.Forms.TextBox encryptTxt;
        private System.Windows.Forms.Button chooseCertifBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.CheckBox devProdButton;
    }
}