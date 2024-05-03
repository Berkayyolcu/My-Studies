namespace Rehber
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
            this.rehber = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rehber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rehber
            // 
            this.rehber.Controls.Add(this.dataGridView1);
            this.rehber.Location = new System.Drawing.Point(3, 0);
            this.rehber.Name = "rehber";
            this.rehber.Size = new System.Drawing.Size(717, 558);
            this.rehber.TabIndex = 0;
            this.rehber.TabStop = false;
            this.rehber.Text = "Rehber";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 532);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtıd);
            this.groupBox1.Controls.Add(this.msktelefon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(726, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kişi";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(211, 415);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(125, 37);
            this.btngüncelle.TabIndex = 7;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(123, 415);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 37);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(35, 415);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(82, 37);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "TELEFON :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(117, 298);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(167, 27);
            this.txtmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "MAİL :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(133, 201);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(167, 27);
            this.txtsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SOYAD :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(103, 156);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(167, 27);
            this.txtad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "AD :";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(103, 108);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(167, 27);
            this.txtıd.TabIndex = 9;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(154, 249);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(167, 27);
            this.msktelefon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-152, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rehber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rehberim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rehber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rehber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnekle;
    }
}

