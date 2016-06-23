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
    public partial class HakemForm : Form
    {
        HakemController hkmcon;
        ComponentConfiguration config;

        public HakemForm()
        {
            InitializeComponent();
            hkmcon = new HakemController();
             ilklemeYap();
        }
        
        private void ilklemeYap()
        {
            dataGVHakem.DataSource = hkmcon.hakemleriCek();
            comboxHakemTur.SelectedIndex = 0;
            comboxHakemKlasman.SelectedIndex = 0;
            comboxHakemBölge.SelectedIndex = 0;
        }

      
        private void btnHizala_Click(object sender, EventArgs e)
        {
            if (rbtnAd.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnAd.Text);
            else if (rbtnSoyad.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnSoyad.Text);
            else if (rbtnTur.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnTur.Text);
            else if (rbtnKlasman.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnKlasman.Text);
            else if (rbtnBolge.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnBolge.Text);
            else if (rbtnGrup.Checked)
                dataGVHakem.DataSource = hkmcon.hakemleriHizala(rbtnGrup.Text);

        }

        private void btnHakemEkle_Click(object sender, EventArgs e)
        {

            Hakem hkm = hakemEkleGirdiKontrol();

            if (hkm != null)
            {
                hkmcon.yeniHakemKaydet(hkm);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                kayitPaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }

        }

        private Hakem hakemEkleGirdiKontrol()
        {
            if (!txtHakemAdi.Text.Equals("") && !txtHakemSoyadi.Text.Equals(""))
            {
                Hakem hkm = new Hakem();
                hkm.hakem_adi = txtHakemAdi.Text;
                hkm.hakem_soyadi= txtHakemSoyadi.Text;
                hkm.hakem_tur = comboxHakemTur.SelectedItem.ToString();
                hkm.hakem_klasman = comboxHakemKlasman.SelectedItem.ToString();
                hkm.hakem_bolge = comboxHakemBölge.SelectedItem.ToString();

                grupAyarla(hkm);

                return hkm;
            }
            else
            {
                labelHata.Text = "HATA ! Hakem adı ve soyadı boş girilemez.";
                return null;
            }
        }

        private void grupAyarla(Hakem hkm)
        {
            if (txtHakemYeniGrup.Text.Equals(""))
            {
                if (comboxHakemEskiGrup.SelectedIndex !=-1)
                {
                    hkm.hakem_grup = comboxHakemEskiGrup.SelectedItem.ToString();
                }
                else
                {
                    hkm.hakem_grup = "yok";
                }  
            }
            else
            {
                hkm.hakem_grup = txtHakemYeniGrup.Text;
            }
                  
        }

        private void btnHakemEkleAc_Click(object sender, EventArgs e)
        {
            comboxHakemEskiGrup.DataSource = hkmcon.hakemGruplariniCek();
            comboxHakemEskiGrup.DisplayMember = "hakem_grup";
            //Kayıt işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelHakemGuncelle.Show();
            panelHakemEkle.Show();
           

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            kayitPaneliniTemizle();
        }

        private void kayitPaneliniTemizle()
        {
            txtHakemAdi.Text = "";
            txtHakemSoyadi.Text = "";
            txtHakemYeniGrup.Text = "";
            comboxHakemTur.SelectedIndex = 0;
            comboxHakemTur.SelectedIndex = 0;
            comboxHakemBölge.SelectedIndex = 0;
            labelHata.Text = "";
        }

        private void btnTabloGuncelle_Click(object sender, EventArgs e)
        {
            dataGVHakem.DataSource = hkmcon.hakemleriCek();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbtnAd.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnAd.Text, txtAra.Text);
            else if (rbtnTur.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnTur.Text, txtAra.Text);
            else if (rbtnSoyad.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnSoyad.Text, txtAra.Text);
            else if (rbtnKlasman.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnKlasman.Text, txtAra.Text);
            else if (rbtnBolge.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnBolge.Text, txtAra.Text);
            else if (rbtnGrup.Checked)
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap(rbtnGrup.Text, txtAra.Text);
            else
                dataGVHakem.DataSource = hkmcon.hakemlerdeAramaYap("Ad", txtAra.Text);
        }

        private void btnHakemSil_Click(object sender, EventArgs e)
        {
            int hakemid = (int)dataGVHakem.CurrentRow.Cells["hakem_id"].Value;
            string hakemadi = dataGVHakem.CurrentRow.Cells["hakem_adi"].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show(hakemadi + " hakemi silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hkmcon.hakemSil(hakemid);

                //sildikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }


        }

        private void btnHakemGuncelleAc_Click(object sender, EventArgs e)
        {
            comboxHGeskigrup.DataSource = hkmcon.hakemGruplariniCek();
            comboxHGeskigrup.DisplayMember = "hakem_grup";
            panelHakemGuncelleDoldur();
            //Güncelleme işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelHakemEkle.Hide();
            panelHakemGuncelle.Show();

           
        }

        private void btnHGuncelle_Click(object sender, EventArgs e)
        {

            Hakem hkm = hakemGuncelleGirdiKontrol();

            if (hkm != null)
            {
                hkmcon.hakemGuncelle(hkm);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                guncellePaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }

        }

        private Hakem hakemGuncelleGirdiKontrol()
        {
            if (!txtHGadi.Text.Equals("") && !txtHGsoyadi.Text.Equals(""))
            {
                Hakem hkm = new Hakem();
                hkm.hakem_id = (int)txtHGadi.Tag;
                hkm.hakem_adi = txtHGadi.Text;
                hkm.hakem_soyadi = txtHGsoyadi.Text;
                hkm.hakem_tur = comboxHGturu.SelectedItem.ToString();
                hkm.hakem_klasman = comboxHGklasman.SelectedItem.ToString();
                hkm.hakem_bolge = comboxHGbölge.SelectedItem.ToString();

                grupAyarlaHG(hkm);
               
                return hkm;
            }
            else
            {
                labelTGHata.Text = "HATA ! Hakem adı ve soyadı boş girilemez.";
                return null;
            }

        }

         private void grupAyarlaHG(Hakem hkm)
        {
            if (txtHGyenigrup.Text.Equals(""))
            {
                if (comboxHGeskigrup.SelectedIndex != -1)
                {
                    hkm.hakem_grup = comboxHGeskigrup.SelectedItem.ToString();
                }
                else
                {
                    hkm.hakem_grup = "yok";
                }  
            }
            else
            {
                hkm.hakem_grup = txtHGyenigrup.Text;
            }
                  
        }
        private void btnHGuncelleIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            guncellePaneliniTemizle();
        }

        private void guncellePaneliniTemizle()
        {
            txtHGadi.Text = "";
            txtHGsoyadi.Text = "";
            txtHGyenigrup.Text = "";
            comboxHGturu.SelectedIndex = 0;
            comboxHGklasman.SelectedIndex = 0;
            comboxHGbölge.SelectedIndex = 0;
            labelTGHata.Text = "";
        }

        private void dataGVHakem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGVHakem.CurrentRow;

            txtHGadi.Tag = row.Cells["hakem_id"].Value;
            txtHGadi.Text = row.Cells["hakem_adi"].Value.ToString();
            txtHGsoyadi.Text = row.Cells["hakem_soyadi"].Value.ToString();
            comboxHGturu.SelectedItem = row.Cells["hakem_tur"].Value;
            comboxHGklasman.SelectedItem = row.Cells["hakem_klasman"].Value;
            comboxHGbölge.SelectedItem = row.Cells["hakem_bolge"].Value;
            comboxHGeskigrup.SelectedItem = row.Cells["hakem_grup"].Value;
            
        }

        private void panelHakemGuncelleDoldur()
        {
            DataGridViewRow row = dataGVHakem.CurrentRow;
            if (txtHGadi.Tag != null)
            {
                txtHGadi.Tag = row.Cells["hakem_id"].Value;
                txtHGadi.Text = row.Cells["hakem_adi"].Value.ToString();
                txtHGsoyadi.Text = row.Cells["hakem_soyadi"].Value.ToString();
                comboxHGturu.SelectedItem = row.Cells["hakem_tur"].Value;
                comboxHGklasman.SelectedItem = row.Cells["hakem_klasman"].Value;
                comboxHGbölge.SelectedItem = row.Cells["hakem_bolge"].Value;
                comboxHGeskigrup.SelectedItem = row.Cells["hakem_grup"].Value;
            }
            
        }

        private void HakemForm_Load(object sender, EventArgs e)
        {
            config = ComponentConfiguration.configureGetir();

            componentAyarla(panelListele.Controls);
            componentAyarla(panelHakemEkle.Controls);
            componentAyarla(panelHakemGuncelle.Controls);

            panelHakemEkle.BackColor = config.getPanelBgcolorTip2;
            panelHakemGuncelle.BackColor = config.getPanelBgcolorTip1;
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
