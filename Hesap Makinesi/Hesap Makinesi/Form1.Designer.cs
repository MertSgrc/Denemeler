
namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.bTopla = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bCıkar = new System.Windows.Forms.Button();
            this.bBol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSil = new System.Windows.Forms.Button();
            this.bEsit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 102);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 50);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(105, 102);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 50);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(105, 158);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 50);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(175, 158);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 50);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(105, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 50);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(175, 102);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 50);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(175, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 50);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // bTopla
            // 
            this.bTopla.Location = new System.Drawing.Point(248, 270);
            this.bTopla.Name = "bTopla";
            this.bTopla.Size = new System.Drawing.Size(64, 50);
            this.bTopla.TabIndex = 0;
            this.bTopla.Text = "+";
            this.bTopla.UseVisualStyleBackColor = true;
            this.bTopla.Click += new System.EventHandler(this.OptHesapla);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(175, 270);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 50);
            this.button11.TabIndex = 0;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(32, 270);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(137, 50);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.RakamOlay);
            // 
            // bCarp
            // 
            this.bCarp.Location = new System.Drawing.Point(248, 158);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(64, 50);
            this.bCarp.TabIndex = 0;
            this.bCarp.Text = "x";
            this.bCarp.UseVisualStyleBackColor = true;
            this.bCarp.Click += new System.EventHandler(this.OptHesapla);
            // 
            // bCıkar
            // 
            this.bCıkar.Location = new System.Drawing.Point(248, 214);
            this.bCıkar.Name = "bCıkar";
            this.bCıkar.Size = new System.Drawing.Size(64, 50);
            this.bCıkar.TabIndex = 0;
            this.bCıkar.Text = "-";
            this.bCıkar.UseVisualStyleBackColor = true;
            this.bCıkar.Click += new System.EventHandler(this.OptHesapla);
            // 
            // bBol
            // 
            this.bBol.Location = new System.Drawing.Point(248, 102);
            this.bBol.Name = "bBol";
            this.bBol.Size = new System.Drawing.Size(64, 50);
            this.bBol.TabIndex = 0;
            this.bBol.Text = "/";
            this.bBol.UseVisualStyleBackColor = true;
            this.bBol.Click += new System.EventHandler(this.OptHesapla);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 22);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEsit);
            this.groupBox1.Controls.Add(this.bSil);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.bBol);
            this.groupBox1.Controls.Add(this.bCarp);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.bTopla);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.bCıkar);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Location = new System.Drawing.Point(88, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(318, 102);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(63, 106);
            this.bSil.TabIndex = 2;
            this.bSil.Text = "C";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEsit
            // 
            this.bEsit.Location = new System.Drawing.Point(318, 214);
            this.bEsit.Name = "bEsit";
            this.bEsit.Size = new System.Drawing.Size(63, 106);
            this.bEsit.TabIndex = 2;
            this.bEsit.Text = "=";
            this.bEsit.UseVisualStyleBackColor = true;
            this.bEsit.Click += new System.EventHandler(this.bEsit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 588);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button bTopla;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bCıkar;
        private System.Windows.Forms.Button bBol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEsit;
        private System.Windows.Forms.Button bSil;
    }
}

