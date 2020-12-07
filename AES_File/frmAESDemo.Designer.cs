
namespace AES_File
{
    partial class frmAESDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.rdEncrypt = new System.Windows.Forms.RadioButton();
            this.rdDecypt = new System.Windows.Forms.RadioButton();
            this.btnExcute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(31, 48);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(327, 27);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(364, 48);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(94, 29);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // rdEncrypt
            // 
            this.rdEncrypt.AutoSize = true;
            this.rdEncrypt.Location = new System.Drawing.Point(31, 95);
            this.rdEncrypt.Name = "rdEncrypt";
            this.rdEncrypt.Size = new System.Drawing.Size(104, 24);
            this.rdEncrypt.TabIndex = 3;
            this.rdEncrypt.TabStop = true;
            this.rdEncrypt.Text = "Encrypt file";
            this.rdEncrypt.UseVisualStyleBackColor = true;
            this.rdEncrypt.CheckedChanged += new System.EventHandler(this.rdEncrypt_CheckedChanged);
            // 
            // rdDecypt
            // 
            this.rdDecypt.AutoSize = true;
            this.rdDecypt.Location = new System.Drawing.Point(217, 95);
            this.rdDecypt.Name = "rdDecypt";
            this.rdDecypt.Size = new System.Drawing.Size(107, 24);
            this.rdDecypt.TabIndex = 4;
            this.rdDecypt.TabStop = true;
            this.rdDecypt.Text = "Decrypt file";
            this.rdDecypt.UseVisualStyleBackColor = true;
            this.rdDecypt.CheckedChanged += new System.EventHandler(this.rdDecypt_CheckedChanged);
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(31, 172);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(427, 29);
            this.btnExcute.TabIndex = 5;
            this.btnExcute.Text = "Start";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // frmAESDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 222);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.rdDecypt);
            this.Controls.Add(this.rdEncrypt);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Name = "frmAESDemo";
            this.Text = "Aes";
            this.Load += new System.EventHandler(this.frmAESDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.RadioButton rdEncrypt;
        private System.Windows.Forms.RadioButton rdDecypt;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

