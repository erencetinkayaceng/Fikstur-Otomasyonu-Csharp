namespace HakemOtomasyonTD
{
    partial class AnaForm
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
            this.pictureBoxAna = new System.Windows.Forms.PictureBox();
            this.btnSalon = new System.Windows.Forms.Button();
            this.btnTakim = new System.Windows.Forms.Button();
            this.btnHakem = new System.Windows.Forms.Button();
            this.btnFikstur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAna)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAna
            // 
            this.pictureBoxAna.Image = global::HakemOtomasyonTD.Properties.Resources.thf;
            this.pictureBoxAna.Location = new System.Drawing.Point(137, 24);
            this.pictureBoxAna.Name = "pictureBoxAna";
            this.pictureBoxAna.Size = new System.Drawing.Size(109, 111);
            this.pictureBoxAna.TabIndex = 5;
            this.pictureBoxAna.TabStop = false;
            // 
            // btnSalon
            // 
            this.btnSalon.Location = new System.Drawing.Point(211, 166);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(150, 45);
            this.btnSalon.TabIndex = 4;
            this.btnSalon.Text = "Spor Salonu İşlemleri";
            this.btnSalon.UseVisualStyleBackColor = true;
            this.btnSalon.Click += new System.EventHandler(this.btnSalon_Click);
            // 
            // btnTakim
            // 
            this.btnTakim.Location = new System.Drawing.Point(26, 166);
            this.btnTakim.Name = "btnTakim";
            this.btnTakim.Size = new System.Drawing.Size(150, 45);
            this.btnTakim.TabIndex = 3;
            this.btnTakim.Text = "Takım İşlemleri";
            this.btnTakim.UseVisualStyleBackColor = true;
            this.btnTakim.Click += new System.EventHandler(this.btnTakim_Click);
            // 
            // btnHakem
            // 
            this.btnHakem.Location = new System.Drawing.Point(26, 217);
            this.btnHakem.Name = "btnHakem";
            this.btnHakem.Size = new System.Drawing.Size(150, 45);
            this.btnHakem.TabIndex = 6;
            this.btnHakem.Text = "Hakem İşlemleri";
            this.btnHakem.UseVisualStyleBackColor = true;
            this.btnHakem.Click += new System.EventHandler(this.btnHakem_Click);
            // 
            // btnFikstur
            // 
            this.btnFikstur.Location = new System.Drawing.Point(211, 217);
            this.btnFikstur.Name = "btnFikstur";
            this.btnFikstur.Size = new System.Drawing.Size(150, 45);
            this.btnFikstur.TabIndex = 7;
            this.btnFikstur.Text = "Fikstür İşlemleri";
            this.btnFikstur.UseVisualStyleBackColor = true;
            this.btnFikstur.Click += new System.EventHandler(this.btnFikstur_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 280);
            this.Controls.Add(this.btnFikstur);
            this.Controls.Add(this.btnHakem);
            this.Controls.Add(this.pictureBoxAna);
            this.Controls.Add(this.btnSalon);
            this.Controls.Add(this.btnTakim);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAna;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Button btnTakim;
        private System.Windows.Forms.Button btnHakem;
        private System.Windows.Forms.Button btnFikstur;
    }
}

