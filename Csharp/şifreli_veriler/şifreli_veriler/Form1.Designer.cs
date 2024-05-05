namespace şifreli_veriler
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
            this.btnsifrele = new System.Windows.Forms.Button();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsifrecöz = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsifrele
            // 
            this.btnsifrele.Location = new System.Drawing.Point(121, 202);
            this.btnsifrele.Name = "btnsifrele";
            this.btnsifrele.Size = new System.Drawing.Size(166, 43);
            this.btnsifrele.TabIndex = 3;
            this.btnsifrele.Text = "Şifrele";
            this.btnsifrele.UseVisualStyleBackColor = true;
            this.btnsifrele.Click += new System.EventHandler(this.btnsifrele_Click);
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(275, 89);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(200, 27);
            this.txtşifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifrenizi Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifreli Metin :";
            // 
            // btnsifrecöz
            // 
            this.btnsifrecöz.Location = new System.Drawing.Point(293, 202);
            this.btnsifrecöz.Name = "btnsifrecöz";
            this.btnsifrecöz.Size = new System.Drawing.Size(166, 43);
            this.btnsifrecöz.TabIndex = 4;
            this.btnsifrecöz.Text = "Şifreyi Çöz";
            this.btnsifrecöz.UseVisualStyleBackColor = true;
            this.btnsifrecöz.Click += new System.EventHandler(this.btnsifrecöz_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(275, 134);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(200, 27);
            this.txt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 325);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnsifrecöz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsifrele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Metin Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsifrele;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsifrecöz;
        private System.Windows.Forms.TextBox txt;
    }
}

