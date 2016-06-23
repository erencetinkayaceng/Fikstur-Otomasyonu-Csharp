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
    public partial class SalonForm : Form
    {
        SalonController slncon;
        ComponentConfiguration config;

        public SalonForm()
        {
            InitializeComponent();
            slncon = new SalonController();

            ilklemeYap();

        }

        private void SalonForm_Load(object sender, EventArgs e)
        {
            config = ComponentConfiguration.configureGetir();

            componentAyarla(panelListele.Controls);
            componentAyarla(panelSalonEkle.Controls);
            componentAyarla(panelSalonGuncelle.Controls);

            panelSalonEkle.BackColor = config.getPanelBgcolorTip2;
            panelSalonGuncelle.BackColor = config.getPanelBgcolorTip1;
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

        private void ilklemeYap()
        {
            dataGVsalon.DataSource = slncon.salonlariCek();

            comboxSalonSehir.SelectedIndex = 0;
            comboxSalonLigi.SelectedIndex = 0;
            comboxSGsehir.SelectedIndex = 0;
            comboxSGligi.SelectedIndex = 0;

        }

        private void btnHizala_Click(object sender, EventArgs e)
        {
            if (rbtnIsim.Checked)
                dataGVsalon.DataSource = slncon.salonlariHizala(rbtnIsim.Text);
            else if (rbtnSehir.Checked)
                dataGVsalon.DataSource = slncon.salonlariHizala(rbtnSehir.Text);
            else if (rbtnLig.Checked)
                dataGVsalon.DataSource = slncon.salonlariHizala(rbtnLig.Text);
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {

            SporSalonu sln = salonEkleGirdiKontrol();

            if (sln != null)
            {
                slncon.yeniSalonKaydet(sln);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                kayitPaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }
        }

        private SporSalonu salonEkleGirdiKontrol()
        {
            if (!txtSalonAdi.Text.Equals(""))
            {
                SporSalonu sln = new SporSalonu();
                sln.salon_adi = txtSalonAdi.Text;
                sln.salon_sehir = comboxSalonSehir.SelectedItem.ToString();
                sln.salon_ligi = comboxSalonLigi.SelectedItem.ToString();
                sln.salon_diger = rtxtSalonDiger.Text;

                return sln;
            }
            else
            {
                labelHata.Text = "HATA ! Spor salonu adı boş girilemez.";
                return null;
            }

        }

        private void btnSalonEkleAc_Click(object sender, EventArgs e)
        {
            //Kayıt işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelSalonGuncelle.Show();
            panelSalonEkle.Show();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            kayitPaneliniTemizle();
        }

        private void kayitPaneliniTemizle()
        {
            txtSalonAdi.Text = "";
            comboxSalonSehir.SelectedIndex = 0;
            comboxSalonLigi.SelectedIndex = 0;
            rtxtSalonDiger.Text = "";
            labelHata.Text = "";
        }

        private void btnTabloGuncelle_Click(object sender, EventArgs e)
        {
            dataGVsalon.DataSource = slncon.salonlariCek();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbtnIsim.Checked)
                dataGVsalon.DataSource = slncon.salonlardaAramaYap(rbtnIsim.Text, txtAra.Text);
            else if (rbtnLig.Checked)
                dataGVsalon.DataSource = slncon.salonlardaAramaYap(rbtnLig.Text, txtAra.Text);
            else if (rbtnSehir.Checked)
                dataGVsalon.DataSource = slncon.salonlardaAramaYap(rbtnSehir.Text, txtAra.Text);
            else
                dataGVsalon.DataSource = slncon.salonlardaAramaYap("İsim", txtAra.Text);
        }

        private void btnSalonSil_Click(object sender, EventArgs e)
        {
            int salonid = (int)dataGVsalon.CurrentRow.Cells["salon_id"].Value;
            string salonadi = dataGVsalon.CurrentRow.Cells["salon_adi"].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show(salonadi + " salonunu silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                slncon.salonSil(salonid);

                //sildikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }


        }

        private void btnSalonGuncelleAc_Click(object sender, EventArgs e)
        {

            panelSalonGuncelleDoldur();
            //Kayıt işlemi için paneli görünür yap
            this.Size = this.MaximumSize;
            panelSalonEkle.Hide();
            panelSalonGuncelle.Show();
        }

        private void btnSGuncelle_Click(object sender, EventArgs e)
        {

            SporSalonu sln = salonGuncelleGirdiKontrol();

            if (sln != null)
            {
                slncon.salonGuncelle(sln);

                //Kayıt işlemi yapıldıktan sonra paneli gizle
                this.Size = this.MinimumSize;

                guncellePaneliniTemizle();

                //ekledikten sonra tabloyu güncelle
                btnTabloGuncelle_Click(sender, e);

            }

        }

        private SporSalonu salonGuncelleGirdiKontrol()
        {
            if (!txtSGadi.Text.Equals(""))
            {
                SporSalonu sln = new SporSalonu();
                sln.salon_id = (int)txtSGadi.Tag;
                sln.salon_adi = txtSGadi.Text;
                sln.salon_sehir = comboxSGsehir.SelectedItem.ToString();
                sln.salon_ligi = comboxSGligi.SelectedItem.ToString();
                sln.salon_diger = rtxtSGdiger.Text;

                return sln;
            }
            else
            {
                labelSGHata.Text = "HATA ! Spor salonu adı boş girilemez.";
                return null;
            }

        }

        private void btnSGuncelleIptal_Click(object sender, EventArgs e)
        {
            //Paneli gizle
            this.Size = this.MinimumSize;
            guncellePaneliniTemizle();
        }

        private void guncellePaneliniTemizle()
        {
            txtSGadi.Text = "";
            comboxSGsehir.SelectedIndex = 0;
            comboxSGligi.SelectedIndex = 0;
            rtxtSGdiger.Text = "";
            labelSGHata.Text = "";
        }

        private void dataGVsalon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGVsalon.CurrentRow;

            txtSGadi.Tag = row.Cells["salon_id"].Value;
            txtSGadi.Text = row.Cells["salon_adi"].Value.ToString();
            comboxSGsehir.SelectedItem = row.Cells["salon_sehir"].Value;
            comboxSGligi.SelectedItem = row.Cells["salon_ligi"].Value;
            rtxtSGdiger.Text = row.Cells["salon_diger"].Value.ToString();

        }

        private void panelSalonGuncelleDoldur()
        {
            DataGridViewRow row = dataGVsalon.CurrentRow;
            if (txtSGadi.Tag != null) { 
            txtSGadi.Tag = row.Cells["salon_id"].Value;
            txtSGadi.Text = row.Cells["salon_adi"].Value.ToString();
            comboxSGsehir.SelectedItem = row.Cells["salon_sehir"].Value;
            comboxSGligi.SelectedItem = row.Cells["salon_ligi"].Value;
            rtxtSGdiger.Text = row.Cells["salon_diger"].Value.ToString();
            }
            
        }

       
    }
}
