namespace mesajlasma_uygulaması
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
            this.msknumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngiriş = new System.Windows.Forms.Button();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msknumara
            // 
            this.msknumara.Location = new System.Drawing.Point(209, 158);
            this.msknumara.Mask = "00000";
            this.msknumara.Name = "msknumara";
            this.msknumara.Size = new System.Drawing.Size(260, 27);
            this.msknumara.TabIndex = 1;
            this.msknumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara :";
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(318, 242);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(151, 56);
            this.btngiriş.TabIndex = 3;
            this.btngiriş.Text = "Giriş Yap";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(209, 197);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(260, 27);
            this.txtşifre.TabIndex = 2;
            this.txtşifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msknumara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Login Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msknumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Label label2;
    }
}

