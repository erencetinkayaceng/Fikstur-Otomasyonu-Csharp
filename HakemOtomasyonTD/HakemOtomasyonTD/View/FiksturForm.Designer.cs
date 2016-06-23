namespace HakemOtomasyonTD.View
{
    partial class FiksturForm
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
            this.panelArkazemin = new System.Windows.Forms.Panel();
            this.btnFiksturSil = new System.Windows.Forms.Button();
            this.labelHata = new System.Windows.Forms.Label();
            this.labelGunal = new System.Windows.Forms.Label();
            this.dtpFiksturBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnFiksturGoster = new System.Windows.Forms.Button();
            this.comboHafta = new System.Windows.Forms.ComboBox();
            this.dataGVFikstur = new System.Windows.Forms.DataGridView();
            this.btnFiksturOlustur = new System.Windows.Forms.Button();
            this.comboLig = new System.Windows.Forms.ComboBox();
            this.panelArkazemin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFikstur)).BeginInit();
            this.SuspendLayout();
            // 
            // panelArkazemin
            // 
            this.panelArkazemin.Controls.Add(this.btnFiksturSil);
            this.panelArkazemin.Controls.Add(this.labelHata);
            this.panelArkazemin.Controls.Add(this.labelGunal);
            this.panelArkazemin.Controls.Add(this.dtpFiksturBaslangic);
            this.panelArkazemin.Controls.Add(this.btnFiksturGoster);
            this.panelArkazemin.Controls.Add(this.comboHafta);
            this.panelArkazemin.Controls.Add(this.dataGVFikstur);
            this.panelArkazemin.Controls.Add(this.btnFiksturOlustur);
            this.panelArkazemin.Controls.Add(this.comboLig);
            this.panelArkazemin.Location = new System.Drawing.Point(1, 1);
            this.panelArkazemin.Name = "panelArkazemin";
            this.panelArkazemin.Size = new System.Drawing.Size(707, 461);
            this.panelArkazemin.TabIndex = 0;
            // 
            // btnFiksturSil
            // 
            this.btnFiksturSil.Location = new System.Drawing.Point(505, 59);
            this.btnFiksturSil.Name = "btnFiksturSil";
            this.btnFiksturSil.Size = new System.Drawing.Size(150, 40);
            this.btnFiksturSil.TabIndex = 8;
            this.btnFiksturSil.Text = "Fikstür Sil";
            this.btnFiksturSil.UseVisualStyleBackColor = true;
            this.btnFiksturSil.Click += new System.EventHandler(this.btnFiksturSil_Click);
            // 
            // labelHata
            // 
            this.labelHata.AutoSize = true;
            this.labelHata.Location = new System.Drawing.Point(11, 440);
            this.labelHata.Name = "labelHata";
            this.labelHata.Size = new System.Drawing.Size(36, 13);
            this.labelHata.TabIndex = 7;
            this.labelHata.Text = "Hata :";
            // 
            // labelGunal
            // 
            this.labelGunal.AutoSize = true;
            this.labelGunal.Location = new System.Drawing.Point(349, 14);
            this.labelGunal.Name = "labelGunal";
            this.labelGunal.Size = new System.Drawing.Size(116, 13);
            this.labelGunal.TabIndex = 6;
            this.labelGunal.Text = "Fikstur Başlangıç Tarihi";
            // 
            // dtpFiksturBaslangic
            // 
            this.dtpFiksturBaslangic.Location = new System.Drawing.Point(349, 33);
            this.dtpFiksturBaslangic.Name = "dtpFiksturBaslangic";
            this.dtpFiksturBaslangic.Size = new System.Drawing.Size(150, 20);
            this.dtpFiksturBaslangic.TabIndex = 5;
            // 
            // btnFiksturGoster
            // 
            this.btnFiksturGoster.Location = new System.Drawing.Point(193, 59);
            this.btnFiksturGoster.Name = "btnFiksturGoster";
            this.btnFiksturGoster.Size = new System.Drawing.Size(150, 40);
            this.btnFiksturGoster.TabIndex = 4;
            this.btnFiksturGoster.Text = "Fikstur Göster";
            this.btnFiksturGoster.UseVisualStyleBackColor = true;
            this.btnFiksturGoster.Click += new System.EventHandler(this.btnFiksturGoster_Click);
            // 
            // comboHafta
            // 
            this.comboHafta.FormattingEnabled = true;
            this.comboHafta.Location = new System.Drawing.Point(22, 70);
            this.comboHafta.Name = "comboHafta";
            this.comboHafta.Size = new System.Drawing.Size(155, 21);
            this.comboHafta.TabIndex = 3;
            // 
            // dataGVFikstur
            // 
            this.dataGVFikstur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVFikstur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFikstur.Location = new System.Drawing.Point(3, 101);
            this.dataGVFikstur.Name = "dataGVFikstur";
            this.dataGVFikstur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVFikstur.Size = new System.Drawing.Size(700, 336);
            this.dataGVFikstur.TabIndex = 2;
            // 
            // btnFiksturOlustur
            // 
            this.btnFiksturOlustur.Location = new System.Drawing.Point(349, 59);
            this.btnFiksturOlustur.Name = "btnFiksturOlustur";
            this.btnFiksturOlustur.Size = new System.Drawing.Size(150, 40);
            this.btnFiksturOlustur.TabIndex = 1;
            this.btnFiksturOlustur.Text = "Fikstür Oluştur";
            this.btnFiksturOlustur.UseVisualStyleBackColor = true;
            this.btnFiksturOlustur.Click += new System.EventHandler(this.btnFiksturOlustur_Click);
            // 
            // comboLig
            // 
            this.comboLig.FormattingEnabled = true;
            this.comboLig.Items.AddRange(new object[] {
            "Süperlig Erkek",
            "Süperlig Bayan",
            "1. Lig Bayan",
            "1. Lig Erkek",
            "2. Lig Bayan A Grubu",
            "2. Lig Bayan B Grubu",
            "2. Lig Erkek A Grubu",
            "2. Lig Erkek B Grubu",
            "2. Lig Erkek C Grubu",
            "2. Lig Erkek D Grubu"});
            this.comboLig.Location = new System.Drawing.Point(22, 23);
            this.comboLig.Name = "comboLig";
            this.comboLig.Size = new System.Drawing.Size(155, 21);
            this.comboLig.TabIndex = 0;
            this.comboLig.SelectionChangeCommitted += new System.EventHandler(this.comboLig_SelectionChangeCommitted);
            // 
            // FiksturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.panelArkazemin);
            this.MaximumSize = new System.Drawing.Size(725, 500);
            this.MinimumSize = new System.Drawing.Size(725, 500);
            this.Name = "FiksturForm";
            this.Text = "FiksturForm";
            this.panelArkazemin.ResumeLayout(false);
            this.panelArkazemin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFikstur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArkazemin;
        private System.Windows.Forms.Button btnFiksturOlustur;
        private System.Windows.Forms.ComboBox comboLig;
        private System.Windows.Forms.DataGridView dataGVFikstur;
        private System.Windows.Forms.Button btnFiksturGoster;
        private System.Windows.Forms.ComboBox comboHafta;
        private System.Windows.Forms.DateTimePicker dtpFiksturBaslangic;
        private System.Windows.Forms.Label labelGunal;
        private System.Windows.Forms.Label labelHata;
        private System.Windows.Forms.Button btnFiksturSil;
    }
}