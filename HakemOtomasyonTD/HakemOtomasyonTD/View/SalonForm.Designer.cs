namespace HakemOtomasyonTD.View
{
    partial class SalonForm
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
            this.panelListele = new System.Windows.Forms.Panel();
            this.rbtnSehir = new System.Windows.Forms.RadioButton();
            this.btnSalonSil = new System.Windows.Forms.Button();
            this.btnSalonGuncelleAc = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.labelKriterAra = new System.Windows.Forms.Label();
            this.btnHizala = new System.Windows.Forms.Button();
            this.rbtnLig = new System.Windows.Forms.RadioButton();
            this.rbtnIsim = new System.Windows.Forms.RadioButton();
            this.labelKriter = new System.Windows.Forms.Label();
            this.btnTabloGuncelle = new System.Windows.Forms.Button();
            this.btnSalonEkleAc = new System.Windows.Forms.Button();
            this.dataGVsalon = new System.Windows.Forms.DataGridView();
            this.panelSalonGuncelle = new System.Windows.Forms.Panel();
            this.panelSalonEkle = new System.Windows.Forms.Panel();
            this.btnSKIptal = new System.Windows.Forms.Button();
            this.labelHata = new System.Windows.Forms.Label();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.rtxtSalonDiger = new System.Windows.Forms.RichTextBox();
            this.comboxSalonLigi = new System.Windows.Forms.ComboBox();
            this.comboxSalonSehir = new System.Windows.Forms.ComboBox();
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.labelSalonDiger = new System.Windows.Forms.Label();
            this.labelSalonLigi = new System.Windows.Forms.Label();
            this.labelSalonSehir = new System.Windows.Forms.Label();
            this.labelSalonAdi = new System.Windows.Forms.Label();
            this.labelSalonEkle = new System.Windows.Forms.Label();
            this.labelSGHata = new System.Windows.Forms.Label();
            this.btnSGIptal = new System.Windows.Forms.Button();
            this.btnSGuncelle = new System.Windows.Forms.Button();
            this.rtxtSGdiger = new System.Windows.Forms.RichTextBox();
            this.comboxSGligi = new System.Windows.Forms.ComboBox();
            this.comboxSGsehir = new System.Windows.Forms.ComboBox();
            this.txtSGadi = new System.Windows.Forms.TextBox();
            this.labelSGdiger = new System.Windows.Forms.Label();
            this.labelSGligi = new System.Windows.Forms.Label();
            this.labelSGsehir = new System.Windows.Forms.Label();
            this.labelSGadi = new System.Windows.Forms.Label();
            this.labelSalonGuncelle = new System.Windows.Forms.Label();
            this.panelListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVsalon)).BeginInit();
            this.panelSalonGuncelle.SuspendLayout();
            this.panelSalonEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListele
            // 
            this.panelListele.Controls.Add(this.rbtnSehir);
            this.panelListele.Controls.Add(this.btnSalonSil);
            this.panelListele.Controls.Add(this.btnSalonGuncelleAc);
            this.panelListele.Controls.Add(this.btnAra);
            this.panelListele.Controls.Add(this.txtAra);
            this.panelListele.Controls.Add(this.labelKriterAra);
            this.panelListele.Controls.Add(this.btnHizala);
            this.panelListele.Controls.Add(this.rbtnLig);
            this.panelListele.Controls.Add(this.rbtnIsim);
            this.panelListele.Controls.Add(this.labelKriter);
            this.panelListele.Controls.Add(this.btnTabloGuncelle);
            this.panelListele.Controls.Add(this.btnSalonEkleAc);
            this.panelListele.Controls.Add(this.dataGVsalon);
            this.panelListele.Location = new System.Drawing.Point(2, 0);
            this.panelListele.Name = "panelListele";
            this.panelListele.Size = new System.Drawing.Size(705, 460);
            this.panelListele.TabIndex = 2;
            // 
            // rbtnSehir
            // 
            this.rbtnSehir.AutoSize = true;
            this.rbtnSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSehir.Location = new System.Drawing.Point(486, 15);
            this.rbtnSehir.Name = "rbtnSehir";
            this.rbtnSehir.Size = new System.Drawing.Size(59, 21);
            this.rbtnSehir.TabIndex = 13;
            this.rbtnSehir.TabStop = true;
            this.rbtnSehir.Text = "Sehir";
            this.rbtnSehir.UseVisualStyleBackColor = true;
            // 
            // btnSalonSil
            // 
            this.btnSalonSil.Location = new System.Drawing.Point(176, 54);
            this.btnSalonSil.Name = "btnSalonSil";
            this.btnSalonSil.Size = new System.Drawing.Size(150, 40);
            this.btnSalonSil.TabIndex = 12;
            this.btnSalonSil.Text = "Spor Salonu Sil";
            this.btnSalonSil.UseVisualStyleBackColor = true;
            this.btnSalonSil.Click += new System.EventHandler(this.btnSalonSil_Click);
            // 
            // btnSalonGuncelleAc
            // 
            this.btnSalonGuncelleAc.Location = new System.Drawing.Point(5, 54);
            this.btnSalonGuncelleAc.Name = "btnSalonGuncelleAc";
            this.btnSalonGuncelleAc.Size = new System.Drawing.Size(165, 40);
            this.btnSalonGuncelleAc.TabIndex = 11;
            this.btnSalonGuncelleAc.Text = "Spor Salonu Güncelle";
            this.btnSalonGuncelleAc.UseVisualStyleBackColor = true;
            this.btnSalonGuncelleAc.Click += new System.EventHandler(this.btnSalonGuncelleAc_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(622, 54);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 40);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(474, 65);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(131, 20);
            this.txtAra.TabIndex = 9;
            // 
            // labelKriterAra
            // 
            this.labelKriterAra.AutoSize = true;
            this.labelKriterAra.Location = new System.Drawing.Point(345, 65);
            this.labelKriterAra.Name = "labelKriterAra";
            this.labelKriterAra.Size = new System.Drawing.Size(88, 13);
            this.labelKriterAra.TabIndex = 8;
            this.labelKriterAra.Text = "Kritere Göre Ara :";
            // 
            // btnHizala
            // 
            this.btnHizala.Location = new System.Drawing.Point(622, 5);
            this.btnHizala.Name = "btnHizala";
            this.btnHizala.Size = new System.Drawing.Size(75, 40);
            this.btnHizala.TabIndex = 7;
            this.btnHizala.Text = "Hizala";
            this.btnHizala.UseVisualStyleBackColor = true;
            this.btnHizala.Click += new System.EventHandler(this.btnHizala_Click);
            // 
            // rbtnLig
            // 
            this.rbtnLig.AutoSize = true;
            this.rbtnLig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnLig.Location = new System.Drawing.Point(550, 15);
            this.rbtnLig.Name = "rbtnLig";
            this.rbtnLig.Size = new System.Drawing.Size(45, 21);
            this.rbtnLig.TabIndex = 5;
            this.rbtnLig.TabStop = true;
            this.rbtnLig.Text = "Lig";
            this.rbtnLig.UseVisualStyleBackColor = true;
            // 
            // rbtnIsim
            // 
            this.rbtnIsim.AutoSize = true;
            this.rbtnIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnIsim.Location = new System.Drawing.Point(430, 15);
            this.rbtnIsim.Name = "rbtnIsim";
            this.rbtnIsim.Size = new System.Drawing.Size(50, 21);
            this.rbtnIsim.TabIndex = 4;
            this.rbtnIsim.TabStop = true;
            this.rbtnIsim.Text = "İsim";
            this.rbtnIsim.UseVisualStyleBackColor = true;
            // 
            // labelKriter
            // 
            this.labelKriter.AutoSize = true;
            this.labelKriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKriter.Location = new System.Drawing.Point(383, 17);
            this.labelKriter.Name = "labelKriter";
            this.labelKriter.Size = new System.Drawing.Size(50, 17);
            this.labelKriter.TabIndex = 3;
            this.labelKriter.Text = "Kriter :";
            // 
            // btnTabloGuncelle
            // 
            this.btnTabloGuncelle.Location = new System.Drawing.Point(176, 5);
            this.btnTabloGuncelle.Name = "btnTabloGuncelle";
            this.btnTabloGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnTabloGuncelle.TabIndex = 2;
            this.btnTabloGuncelle.Text = "Tabloyu Güncelle";
            this.btnTabloGuncelle.UseVisualStyleBackColor = true;
            this.btnTabloGuncelle.Click += new System.EventHandler(this.btnTabloGuncelle_Click);
            // 
            // btnSalonEkleAc
            // 
            this.btnSalonEkleAc.Location = new System.Drawing.Point(5, 5);
            this.btnSalonEkleAc.Name = "btnSalonEkleAc";
            this.btnSalonEkleAc.Size = new System.Drawing.Size(165, 40);
            this.btnSalonEkleAc.TabIndex = 1;
            this.btnSalonEkleAc.Text = "Spor Salonu Ekle";
            this.btnSalonEkleAc.UseVisualStyleBackColor = true;
            this.btnSalonEkleAc.Click += new System.EventHandler(this.btnSalonEkleAc_Click);
            // 
            // dataGVsalon
            // 
            this.dataGVsalon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVsalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVsalon.Location = new System.Drawing.Point(3, 100);
            this.dataGVsalon.Name = "dataGVsalon";
            this.dataGVsalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVsalon.Size = new System.Drawing.Size(700, 357);
            this.dataGVsalon.TabIndex = 0;
            this.dataGVsalon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVsalon_CellMouseClick);
            // 
            // panelSalonGuncelle
            // 
            this.panelSalonGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSalonGuncelle.Controls.Add(this.panelSalonEkle);
            this.panelSalonGuncelle.Controls.Add(this.labelSGHata);
            this.panelSalonGuncelle.Controls.Add(this.btnSGIptal);
            this.panelSalonGuncelle.Controls.Add(this.btnSGuncelle);
            this.panelSalonGuncelle.Controls.Add(this.rtxtSGdiger);
            this.panelSalonGuncelle.Controls.Add(this.comboxSGligi);
            this.panelSalonGuncelle.Controls.Add(this.comboxSGsehir);
            this.panelSalonGuncelle.Controls.Add(this.txtSGadi);
            this.panelSalonGuncelle.Controls.Add(this.labelSGdiger);
            this.panelSalonGuncelle.Controls.Add(this.labelSGligi);
            this.panelSalonGuncelle.Controls.Add(this.labelSGsehir);
            this.panelSalonGuncelle.Controls.Add(this.labelSGadi);
            this.panelSalonGuncelle.Controls.Add(this.labelSalonGuncelle);
            this.panelSalonGuncelle.Location = new System.Drawing.Point(709, 0);
            this.panelSalonGuncelle.Name = "panelSalonGuncelle";
            this.panelSalonGuncelle.Size = new System.Drawing.Size(300, 460);
            this.panelSalonGuncelle.TabIndex = 15;
            // 
            // panelSalonEkle
            // 
            this.panelSalonEkle.Controls.Add(this.btnSKIptal);
            this.panelSalonEkle.Controls.Add(this.labelHata);
            this.panelSalonEkle.Controls.Add(this.btnSalonEkle);
            this.panelSalonEkle.Controls.Add(this.rtxtSalonDiger);
            this.panelSalonEkle.Controls.Add(this.comboxSalonLigi);
            this.panelSalonEkle.Controls.Add(this.comboxSalonSehir);
            this.panelSalonEkle.Controls.Add(this.txtSalonAdi);
            this.panelSalonEkle.Controls.Add(this.labelSalonDiger);
            this.panelSalonEkle.Controls.Add(this.labelSalonLigi);
            this.panelSalonEkle.Controls.Add(this.labelSalonSehir);
            this.panelSalonEkle.Controls.Add(this.labelSalonAdi);
            this.panelSalonEkle.Controls.Add(this.labelSalonEkle);
            this.panelSalonEkle.Location = new System.Drawing.Point(0, 0);
            this.panelSalonEkle.Name = "panelSalonEkle";
            this.panelSalonEkle.Size = new System.Drawing.Size(300, 460);
            this.panelSalonEkle.TabIndex = 16;
            // 
            // btnSKIptal
            // 
            this.btnSKIptal.Location = new System.Drawing.Point(185, 357);
            this.btnSKIptal.Name = "btnSKIptal";
            this.btnSKIptal.Size = new System.Drawing.Size(87, 40);
            this.btnSKIptal.TabIndex = 13;
            this.btnSKIptal.Text = "İptal Et";
            this.btnSKIptal.UseVisualStyleBackColor = true;
            this.btnSKIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // labelHata
            // 
            this.labelHata.AutoSize = true;
            this.labelHata.Location = new System.Drawing.Point(58, 420);
            this.labelHata.Name = "labelHata";
            this.labelHata.Size = new System.Drawing.Size(0, 13);
            this.labelHata.TabIndex = 12;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Location = new System.Drawing.Point(29, 357);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(150, 40);
            this.btnSalonEkle.TabIndex = 11;
            this.btnSalonEkle.Text = "Spor Salonu Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // rtxtSalonDiger
            // 
            this.rtxtSalonDiger.Location = new System.Drawing.Point(61, 289);
            this.rtxtSalonDiger.Name = "rtxtSalonDiger";
            this.rtxtSalonDiger.Size = new System.Drawing.Size(195, 50);
            this.rtxtSalonDiger.TabIndex = 10;
            this.rtxtSalonDiger.Text = "";
            // 
            // comboxSalonLigi
            // 
            this.comboxSalonLigi.FormattingEnabled = true;
            this.comboxSalonLigi.Items.AddRange(new object[] {
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
            this.comboxSalonLigi.Location = new System.Drawing.Point(62, 218);
            this.comboxSalonLigi.Name = "comboxSalonLigi";
            this.comboxSalonLigi.Size = new System.Drawing.Size(195, 21);
            this.comboxSalonLigi.TabIndex = 8;
            // 
            // comboxSalonSehir
            // 
            this.comboxSalonSehir.FormattingEnabled = true;
            this.comboxSalonSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboxSalonSehir.Location = new System.Drawing.Point(62, 146);
            this.comboxSalonSehir.Name = "comboxSalonSehir";
            this.comboxSalonSehir.Size = new System.Drawing.Size(195, 21);
            this.comboxSalonSehir.TabIndex = 7;
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(62, 79);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(195, 20);
            this.txtSalonAdi.TabIndex = 6;
            // 
            // labelSalonDiger
            // 
            this.labelSalonDiger.AutoSize = true;
            this.labelSalonDiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonDiger.Location = new System.Drawing.Point(59, 253);
            this.labelSalonDiger.Name = "labelSalonDiger";
            this.labelSalonDiger.Size = new System.Drawing.Size(42, 17);
            this.labelSalonDiger.TabIndex = 5;
            this.labelSalonDiger.Text = "Diğer";
            // 
            // labelSalonLigi
            // 
            this.labelSalonLigi.AutoSize = true;
            this.labelSalonLigi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonLigi.Location = new System.Drawing.Point(59, 187);
            this.labelSalonLigi.Name = "labelSalonLigi";
            this.labelSalonLigi.Size = new System.Drawing.Size(112, 17);
            this.labelSalonLigi.TabIndex = 3;
            this.labelSalonLigi.Text = "Spor Salonu Ligi";
            // 
            // labelSalonSehir
            // 
            this.labelSalonSehir.AutoSize = true;
            this.labelSalonSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonSehir.Location = new System.Drawing.Point(59, 112);
            this.labelSalonSehir.Name = "labelSalonSehir";
            this.labelSalonSehir.Size = new System.Drawing.Size(123, 17);
            this.labelSalonSehir.TabIndex = 2;
            this.labelSalonSehir.Text = "Spor Salonu Şehri";
            // 
            // labelSalonAdi
            // 
            this.labelSalonAdi.AutoSize = true;
            this.labelSalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonAdi.Location = new System.Drawing.Point(59, 49);
            this.labelSalonAdi.Name = "labelSalonAdi";
            this.labelSalonAdi.Size = new System.Drawing.Size(114, 17);
            this.labelSalonAdi.TabIndex = 1;
            this.labelSalonAdi.Text = "Spor Salonu Adı ";
            // 
            // labelSalonEkle
            // 
            this.labelSalonEkle.AutoSize = true;
            this.labelSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonEkle.Location = new System.Drawing.Point(94, 15);
            this.labelSalonEkle.Name = "labelSalonEkle";
            this.labelSalonEkle.Size = new System.Drawing.Size(123, 18);
            this.labelSalonEkle.TabIndex = 0;
            this.labelSalonEkle.Text = "Spor Salonu Ekle";
            // 
            // labelSGHata
            // 
            this.labelSGHata.AutoSize = true;
            this.labelSGHata.Location = new System.Drawing.Point(51, 418);
            this.labelSGHata.Name = "labelSGHata";
            this.labelSGHata.Size = new System.Drawing.Size(0, 13);
            this.labelSGHata.TabIndex = 27;
            // 
            // btnSGIptal
            // 
            this.btnSGIptal.Location = new System.Drawing.Point(196, 362);
            this.btnSGIptal.Name = "btnSGIptal";
            this.btnSGIptal.Size = new System.Drawing.Size(85, 40);
            this.btnSGIptal.TabIndex = 26;
            this.btnSGIptal.Text = "İptal Et";
            this.btnSGIptal.UseVisualStyleBackColor = true;
            this.btnSGIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSGuncelle
            // 
            this.btnSGuncelle.Location = new System.Drawing.Point(15, 362);
            this.btnSGuncelle.Name = "btnSGuncelle";
            this.btnSGuncelle.Size = new System.Drawing.Size(175, 40);
            this.btnSGuncelle.TabIndex = 25;
            this.btnSGuncelle.Text = "Spor Salonunu Güncelle";
            this.btnSGuncelle.UseVisualStyleBackColor = true;
            this.btnSGuncelle.Click += new System.EventHandler(this.btnSGuncelle_Click);
            // 
            // rtxtSGdiger
            // 
            this.rtxtSGdiger.Location = new System.Drawing.Point(54, 296);
            this.rtxtSGdiger.Name = "rtxtSGdiger";
            this.rtxtSGdiger.Size = new System.Drawing.Size(195, 50);
            this.rtxtSGdiger.TabIndex = 24;
            this.rtxtSGdiger.Text = "";
            // 
            // comboxSGligi
            // 
            this.comboxSGligi.FormattingEnabled = true;
            this.comboxSGligi.Items.AddRange(new object[] {
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
            this.comboxSGligi.Location = new System.Drawing.Point(54, 226);
            this.comboxSGligi.Name = "comboxSGligi";
            this.comboxSGligi.Size = new System.Drawing.Size(195, 21);
            this.comboxSGligi.TabIndex = 22;
            // 
            // comboxSGsehir
            // 
            this.comboxSGsehir.FormattingEnabled = true;
            this.comboxSGsehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboxSGsehir.Location = new System.Drawing.Point(54, 154);
            this.comboxSGsehir.Name = "comboxSGsehir";
            this.comboxSGsehir.Size = new System.Drawing.Size(195, 21);
            this.comboxSGsehir.TabIndex = 21;
            // 
            // txtSGadi
            // 
            this.txtSGadi.Location = new System.Drawing.Point(54, 87);
            this.txtSGadi.Name = "txtSGadi";
            this.txtSGadi.Size = new System.Drawing.Size(195, 20);
            this.txtSGadi.TabIndex = 20;
            // 
            // labelSGdiger
            // 
            this.labelSGdiger.AutoSize = true;
            this.labelSGdiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSGdiger.Location = new System.Drawing.Point(51, 263);
            this.labelSGdiger.Name = "labelSGdiger";
            this.labelSGdiger.Size = new System.Drawing.Size(42, 17);
            this.labelSGdiger.TabIndex = 19;
            this.labelSGdiger.Text = "Diğer";
            // 
            // labelSGligi
            // 
            this.labelSGligi.AutoSize = true;
            this.labelSGligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSGligi.Location = new System.Drawing.Point(51, 195);
            this.labelSGligi.Name = "labelSGligi";
            this.labelSGligi.Size = new System.Drawing.Size(112, 17);
            this.labelSGligi.TabIndex = 17;
            this.labelSGligi.Text = "Spor Salonu Ligi";
            // 
            // labelSGsehir
            // 
            this.labelSGsehir.AutoSize = true;
            this.labelSGsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSGsehir.Location = new System.Drawing.Point(51, 120);
            this.labelSGsehir.Name = "labelSGsehir";
            this.labelSGsehir.Size = new System.Drawing.Size(123, 17);
            this.labelSGsehir.TabIndex = 16;
            this.labelSGsehir.Text = "Spor Salonu Şehri";
            // 
            // labelSGadi
            // 
            this.labelSGadi.AutoSize = true;
            this.labelSGadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSGadi.Location = new System.Drawing.Point(51, 57);
            this.labelSGadi.Name = "labelSGadi";
            this.labelSGadi.Size = new System.Drawing.Size(114, 17);
            this.labelSGadi.TabIndex = 15;
            this.labelSGadi.Text = "Spor Salonu Adı ";
            // 
            // labelSalonGuncelle
            // 
            this.labelSalonGuncelle.AutoSize = true;
            this.labelSalonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalonGuncelle.Location = new System.Drawing.Point(80, 27);
            this.labelSalonGuncelle.Name = "labelSalonGuncelle";
            this.labelSalonGuncelle.Size = new System.Drawing.Size(152, 18);
            this.labelSalonGuncelle.TabIndex = 14;
            this.labelSalonGuncelle.Text = "Spor Salonu Güncelle";
            // 
            // SalonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.panelListele);
            this.Controls.Add(this.panelSalonGuncelle);
            this.MaximumSize = new System.Drawing.Size(1025, 500);
            this.MinimumSize = new System.Drawing.Size(725, 500);
            this.Name = "SalonForm";
            this.Text = "SalonForm";
            this.Load += new System.EventHandler(this.SalonForm_Load);
            this.panelListele.ResumeLayout(false);
            this.panelListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVsalon)).EndInit();
            this.panelSalonGuncelle.ResumeLayout(false);
            this.panelSalonGuncelle.PerformLayout();
            this.panelSalonEkle.ResumeLayout(false);
            this.panelSalonEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListele;
        private System.Windows.Forms.RadioButton rbtnSehir;
        private System.Windows.Forms.Button btnSalonSil;
        private System.Windows.Forms.Button btnSalonGuncelleAc;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label labelKriterAra;
        private System.Windows.Forms.Button btnHizala;
        private System.Windows.Forms.RadioButton rbtnLig;
        private System.Windows.Forms.RadioButton rbtnIsim;
        private System.Windows.Forms.Label labelKriter;
        private System.Windows.Forms.Button btnTabloGuncelle;
        private System.Windows.Forms.Button btnSalonEkleAc;
        private System.Windows.Forms.DataGridView dataGVsalon;
        private System.Windows.Forms.Panel panelSalonGuncelle;
        private System.Windows.Forms.Panel panelSalonEkle;
        private System.Windows.Forms.Button btnSKIptal;
        private System.Windows.Forms.Label labelHata;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.RichTextBox rtxtSalonDiger;
        private System.Windows.Forms.ComboBox comboxSalonLigi;
        private System.Windows.Forms.ComboBox comboxSalonSehir;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.Label labelSalonDiger;
        private System.Windows.Forms.Label labelSalonLigi;
        private System.Windows.Forms.Label labelSalonSehir;
        private System.Windows.Forms.Label labelSalonAdi;
        private System.Windows.Forms.Label labelSalonEkle;
        private System.Windows.Forms.Label labelSGHata;
        private System.Windows.Forms.Button btnSGIptal;
        private System.Windows.Forms.Button btnSGuncelle;
        private System.Windows.Forms.RichTextBox rtxtSGdiger;
        private System.Windows.Forms.ComboBox comboxSGligi;
        private System.Windows.Forms.ComboBox comboxSGsehir;
        private System.Windows.Forms.TextBox txtSGadi;
        private System.Windows.Forms.Label labelSGdiger;
        private System.Windows.Forms.Label labelSGligi;
        private System.Windows.Forms.Label labelSGsehir;
        private System.Windows.Forms.Label labelSGadi;
        private System.Windows.Forms.Label labelSalonGuncelle;
    }
}