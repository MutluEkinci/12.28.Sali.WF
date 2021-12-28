
namespace WndDB3
{
    partial class Form1
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
            this.btnSp1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSP2 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.lblUrunNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.btnSP3 = new System.Windows.Forms.Button();
            this.btnSP4 = new System.Windows.Forms.Button();
            this.btnSP5scalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSp1
            // 
            this.btnSp1.Location = new System.Drawing.Point(12, 12);
            this.btnSp1.Name = "btnSp1";
            this.btnSp1.Size = new System.Drawing.Size(111, 46);
            this.btnSp1.TabIndex = 0;
            this.btnSp1.Text = "SP1 Listele";
            this.btnSp1.UseVisualStyleBackColor = true;
            this.btnSp1.Click += new System.EventHandler(this.btnSp1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 228);
            this.listBox1.TabIndex = 1;
            // 
            // btnSP2
            // 
            this.btnSP2.Location = new System.Drawing.Point(113, 439);
            this.btnSP2.Name = "btnSP2";
            this.btnSP2.Size = new System.Drawing.Size(103, 45);
            this.btnSP2.TabIndex = 2;
            this.btnSP2.Text = "SP2 Ekle";
            this.btnSP2.UseVisualStyleBackColor = true;
            this.btnSP2.Click += new System.EventHandler(this.btnSP2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 299);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(113, 327);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(113, 355);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(113, 383);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 22);
            this.txtRenk.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(113, 411);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(12, 304);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(56, 17);
            this.lblUrunID.TabIndex = 4;
            this.lblUrunID.Text = "Urun ID";
            // 
            // lblUrunNo
            // 
            this.lblUrunNo.AutoSize = true;
            this.lblUrunNo.Location = new System.Drawing.Point(12, 332);
            this.lblUrunNo.Name = "lblUrunNo";
            this.lblUrunNo.Size = new System.Drawing.Size(60, 17);
            this.lblUrunNo.TabIndex = 4;
            this.lblUrunNo.Text = "UrunNO";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 360);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(63, 17);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Urun Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 416);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(12, 388);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(41, 17);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "Renk";
            // 
            // btnSP3
            // 
            this.btnSP3.Location = new System.Drawing.Point(425, 64);
            this.btnSP3.Name = "btnSP3";
            this.btnSP3.Size = new System.Drawing.Size(92, 50);
            this.btnSP3.TabIndex = 5;
            this.btnSP3.Text = "SP3 Değer Döndürme";
            this.btnSP3.UseVisualStyleBackColor = true;
            this.btnSP3.Click += new System.EventHandler(this.btnSP3_Click);
            // 
            // btnSP4
            // 
            this.btnSP4.Location = new System.Drawing.Point(425, 120);
            this.btnSP4.Name = "btnSP4";
            this.btnSP4.Size = new System.Drawing.Size(92, 61);
            this.btnSP4.TabIndex = 6;
            this.btnSP4.Text = "SP4 Identity";
            this.btnSP4.UseVisualStyleBackColor = true;
            this.btnSP4.Click += new System.EventHandler(this.btnSP4_Click);
            // 
            // btnSP5scalar
            // 
            this.btnSP5scalar.Location = new System.Drawing.Point(425, 187);
            this.btnSP5scalar.Name = "btnSP5scalar";
            this.btnSP5scalar.Size = new System.Drawing.Size(92, 60);
            this.btnSP5scalar.TabIndex = 7;
            this.btnSP5scalar.Text = "SP5 Scalar";
            this.btnSP5scalar.UseVisualStyleBackColor = true;
            this.btnSP5scalar.Click += new System.EventHandler(this.btnSP5scalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 519);
            this.Controls.Add(this.btnSP5scalar);
            this.Controls.Add(this.btnSP4);
            this.Controls.Add(this.btnSP3);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblUrunNo);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSP2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSp1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSP2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.Label lblUrunNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Button btnSP3;
        private System.Windows.Forms.Button btnSP4;
        private System.Windows.Forms.Button btnSP5scalar;
    }
}

