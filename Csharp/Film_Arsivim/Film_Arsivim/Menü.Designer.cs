namespace Film_Arsivim
{
    partial class Menü
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
            this.btnfilmler = new System.Windows.Forms.Button();
            this.btnfilmizle = new System.Windows.Forms.Button();
            this.btnhakkımızda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfilmler
            // 
            this.btnfilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfilmler.Location = new System.Drawing.Point(161, 230);
            this.btnfilmler.Name = "btnfilmler";
            this.btnfilmler.Size = new System.Drawing.Size(186, 129);
            this.btnfilmler.TabIndex = 0;
            this.btnfilmler.Text = "Filmler";
            this.btnfilmler.UseVisualStyleBackColor = true;
            this.btnfilmler.Click += new System.EventHandler(this.btnfilmler_Click);
            // 
            // btnfilmizle
            // 
            this.btnfilmizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfilmizle.Location = new System.Drawing.Point(353, 230);
            this.btnfilmizle.Name = "btnfilmizle";
            this.btnfilmizle.Size = new System.Drawing.Size(186, 129);
            this.btnfilmizle.TabIndex = 1;
            this.btnfilmizle.Text = "Film İzle";
            this.btnfilmizle.UseVisualStyleBackColor = true;
            this.btnfilmizle.Click += new System.EventHandler(this.btnfilmizle_Click);
            // 
            // btnhakkımızda
            // 
            this.btnhakkımızda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhakkımızda.Location = new System.Drawing.Point(545, 230);
            this.btnhakkımızda.Name = "btnhakkımızda";
            this.btnhakkımızda.Size = new System.Drawing.Size(186, 129);
            this.btnhakkımızda.TabIndex = 2;
            this.btnhakkımızda.Text = "Hakkımızda";
            this.btnhakkımızda.UseVisualStyleBackColor = true;
            this.btnhakkımızda.Click += new System.EventHandler(this.btnhakkımızda_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(894, 513);
            this.Controls.Add(this.btnhakkımızda);
            this.Controls.Add(this.btnfilmizle);
            this.Controls.Add(this.btnfilmler);
            this.Name = "Menü";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfilmler;
        private System.Windows.Forms.Button btnfilmizle;
        private System.Windows.Forms.Button btnhakkımızda;
    }
}