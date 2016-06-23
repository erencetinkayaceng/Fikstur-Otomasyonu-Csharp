using HakemOtomasyonTD.Configure;
using HakemOtomasyonTD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakemOtomasyonTD.View
{
    public partial class TakimForm : Form
    {
        TakimController tkmcon;
        ComponentConfiguration config;

        public TakimForm()
        {
            InitializeComponent();
            tkmcon = new TakimController();

            ilklemeYap();
        }

        private void ilklemeYap()
        {
            dataGVTakim.DataSource = tkmcon.takimlariCek();

            salonComboBoxlariDoldur();

            comboxTakimSehir.SelectedIndex = 0;
            comboxTakimLigi.SelectedIndex = 0;
            comboxTakimSalonu.SelectedIndex = 0;
            comboxTGsalonu.SelectedIndex = 0;
            comboxTGsehir.SelectedIndex = 0;
            comboxTGligi.SelectedIndex = 0;

        }

        private void salonComboBoxlariDoldur()
        {
            //Spor salonu var ise combobox doldur
            if (tkmcon.salonlariCek().Count != 0)
            {
                comboxTakimSalonu.DataSource = tkmcon.salonlariCek();
                comboxTakimSalonu.DisplayMember = "salon_adi";
                comboxTakimSalonu.ValueMember = "salon_adi";

                comboxTGsalonu.DataSource = tkmcon.salonlariCek();
                comboxTGsalonu.DisplayMember = "salon_adi";
                comboxTGsalonu.ValueMember = "salon_adi";
            }
        }

        private void btnHizala_Click(object sender, EventArgs e)
        {
            if (rbtnIsim.Checked)
                dataGVTakim.DataSource = tkmcon.takimlariHizala(rbtnIsim.Text);
            else if (rbtnSehir.Checked)
                dataGVTakim.DataSource = tkmcon.takimlariHizala(rbtnSehir.Text);
            else if (rbtnLig.Checked)
                dataGVTakim.DataSource = tkmcon.takimlariHizala(rbtnLig.Text);
            else if (rbtnSalon.Checked)
                dataGVTakim.DataSource = tkmcon.takimlariHizala(rbtnSalon.Text);

        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {

            Takim tkm = takimEkleGirdiKontrol();

            if (tkm != null)
            {
                tkmcon.yeniTakimKaydet(tkm);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                kayitPaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }

        }

        private Takim takimEkleGirdiKontrol()
        {
            if (!txtTakimAdi.Text.Equals(""))
            {
                Takim tkm = new Takim();
                tkm.takim_adi = txtTakimAdi.Text;
                tkm.takim_sehir = comboxTakimSehir.SelectedItem.ToString();
                tkm.takim_ligi = comboxTakimLigi.SelectedItem.ToString();
                tkm.takim_diger = rtxtTakimDiger.Text;

                //Spor salonu yok ise boş bırakıyoruz
                if (comboxTakimSalonu.SelectedItem.Equals("Yok"))
                    tkm.takim_salon = null;
                else
                    tkm.takim_salon = comboxTakimSalonu.SelectedValue.ToString();

                return tkm;
            }
            else
            {
                labelHata.Text = "HATA ! Takım adı boş girilemez.";
                return null;
            }

        }

        private void btnTakimEkleAc_Click(object sender, EventArgs e)
        {
            salonComboBoxlariDoldur();
            //Kayıt işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelTakimGuncelle.Show();
            panelTakimEkle.Show();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            kayitPaneliniTemizle();
        }

        private void kayitPaneliniTemizle()
        {
            txtTakimAdi.Text = "";
            comboxTakimSehir.SelectedIndex = 0;
            comboxTakimLigi.SelectedIndex = 0;
            comboxTakimSalonu.SelectedIndex = 0;
            rtxtTakimDiger.Text = "";
            labelHata.Text = "";
        }

        private void btnTabloGuncelle_Click(object sender, EventArgs e)
        {
            dataGVTakim.DataSource = tkmcon.takimlariCek();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbtnIsim.Checked)
                dataGVTakim.DataSource = tkmcon.takimlardaAramaYap(rbtnIsim.Text, txtAra.Text);
            else if (rbtnLig.Checked)
                dataGVTakim.DataSource = tkmcon.takimlardaAramaYap(rbtnLig.Text, txtAra.Text);
            else if (rbtnSehir.Checked)
                dataGVTakim.DataSource = tkmcon.takimlardaAramaYap(rbtnSehir.Text, txtAra.Text);
            else
                dataGVTakim.DataSource = tkmcon.takimlardaAramaYap("İsim", txtAra.Text);
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            int takimid = (int)dataGVTakim.CurrentRow.Cells["takim_id"].Value;
            string takimadi = dataGVTakim.CurrentRow.Cells["takim_adi"].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show(takimadi + " takımını silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                tkmcon.takimSil(takimid);

                //sildikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }


        }

        private void btnTakimGuncelleAc_Click(object sender, EventArgs e)
        {
            salonComboBoxlariDoldur();
            panelTakimGuncelleDoldur();
            //Güncelleme işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelTakimEkle.Hide();
            panelTakimGuncelle.Show();
        }

        private void btnTGuncelle_Click(object sender, EventArgs e)
        {

            Takim tkm = takimGuncelleGirdiKontrol();

            if (tkm != null)
            {
                tkmcon.takimGuncelle(tkm);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                guncellePaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }

        }

        private Takim takimGuncelleGirdiKontrol()
        {
            if (!txtTGadi.Text.Equals(""))
            {
                Takim tkm = new Takim();
                tkm.takim_id = (int)txtTGadi.Tag;
                tkm.takim_adi = txtTGadi.Text;
                tkm.takim_sehir = comboxTGsehir.SelectedItem.ToString();
                tkm.takim_ligi = comboxTGligi.SelectedItem.ToString();
                tkm.takim_diger = rtxtTGdiger.Text;

                //Spor salonu yok ise boş bırakıyoruz
                if (comboxTGsalonu.SelectedItem.Equals("Yok"))
                    tkm.takim_salon = null;
                else
                    tkm.takim_salon = comboxTGsalonu.SelectedValue.ToString();

                return tkm;
            }
            else
            {
                labelTGHata.Text = "HATA ! Takım adı boş girilemez.";
                return null;
            }

        }

        private void btnTGuncelleIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            guncellePaneliniTemizle();
        }

        private void guncellePaneliniTemizle()
        {
            txtTGadi.Text = "";
            comboxTGsehir.SelectedIndex = 0;
            comboxTGligi.SelectedIndex = 0;
            comboxTGsalonu.SelectedIndex = 0;
            rtxtTGdiger.Text = "";
            labelTGHata.Text = "";
        }

        private void dataGVTakim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGVTakim.CurrentRow;

            txtTGadi.Tag = row.Cells["takim_id"].Value;
            txtTGadi.Text = row.Cells["takim_adi"].Value.ToString();
            comboxTGsehir.SelectedItem = row.Cells["takim_sehir"].Value;
            comboxTGligi.SelectedItem = row.Cells["takim_ligi"].Value;
            comboxTGsalonu.SelectedItem = row.Cells["takim_salon"].Value;
            rtxtTGdiger.Text = row.Cells["takim_diger"].Value.ToString();

        }

        private void panelTakimGuncelleDoldur()
        {
            DataGridViewRow row = dataGVTakim.CurrentRow;
            if (txtTGadi.Tag != null)
            {
                txtTGadi.Tag = row.Cells["takim_id"].Value;
                txtTGadi.Text = row.Cells["takim_adi"].Value.ToString();
                comboxTGsehir.SelectedItem = row.Cells["takim_sehir"].Value;
                comboxTGligi.SelectedItem = row.Cells["takim_ligi"].Value;
                comboxTGsalonu.SelectedItem = row.Cells["takim_salon"].Value;
                rtxtTGdiger.Text = row.Cells["takim_diger"].Value.ToString();
            }
            
        }

        private void TakimForm_Load(object sender, EventArgs e)
        {
            config = ComponentConfiguration.configureGetir();

            componentAyarla(panelListele.Controls);
            componentAyarla(panelTakimEkle.Controls);
            componentAyarla(panelTakimGuncelle.Controls);

            panelTakimEkle.BackColor = config.getPanelBgcolorTip2;
            panelTakimGuncelle.BackColor = config.getPanelBgcolorTip1;
        }

        private void componentAyarla(Control.ControlCollection cntrl)
        {
            foreach (Control nesne in cntrl)
            {
                if ((nesne) is Button)
                {
                    nesne.Font = config.getButonFont;
                }
                else if ((nesne) is Label)
                {
                    nesne.Font = config.getLabelFont;
                }
            }
        }

    }
}
