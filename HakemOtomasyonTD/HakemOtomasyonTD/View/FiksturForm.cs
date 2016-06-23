using HakemOtomasyonTD.Controller;
using HakemOtomasyonTD.Interface;
using HakemOtomasyonTD.Log;
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
    public partial class FiksturForm : Form ,IGozlenen 
    {
        FiksturController fkcon;
        private List<IGozleyen> gozlemciListesi = new List<IGozleyen>();
        private string islemYapilanLig = "Süperlig Erkek";
        string operasyon;
        public FiksturForm()
        {
            InitializeComponent();
            fkcon = new FiksturController();
            ilklemeYap();
            gozlemciEkle(Logger.loggerGetir());
            gozlemciEkle(fkcon);
        }

        private void ilklemeYap()
        {   //combobox ilk değer seçili yapıyoruz       
            comboLig.SelectedIndex = 0;      
            //lige göre hafta işlemleri yapıyoruz
            int takimSayisi = fkcon.takimlariCek(islemYapilanLig).Count;
            comboHafta.DataSource = haftalariOlustur(takimSayisi);
            comboHafta.SelectedIndex = 0;
        }

        public void gozlemcilereHaberVer(string operasyon, Object obje, string islemYapilanLig)
        {
            foreach (IGozleyen gözlemci in gozlemciListesi)
            {
                gözlemci.guncelle(operasyon, obje, islemYapilanLig);
            }
        }

        public void gozlemciEkle(IGozleyen _gozlemci)
        {
            gozlemciListesi.Add(_gozlemci);
        }

        public void gozlemciSil(IGozleyen _gozlemci)
        {
            gozlemciListesi.Remove(_gozlemci);
        }

        private void btnFiksturOlustur_Click(object sender, EventArgs e)
        {            
            string str=fiksturSartlariSaglandimi();
            if (str.Equals("Evet"))
            {                
                fiksturOlustur();
            }
            else
            {
                labelHata.Text = "Hata : "+ str;
            }
           
        }
      
        private void btnFiksturGoster_Click(object sender, EventArgs e)
        {
            //lig ve hafta bilgisine göre datagridviewe atıyoruz
            if (comboHafta.SelectedValue != null) { 
            dataGVFikstur.DataSource=fkcon.fiksturCek(comboLig.SelectedItem.ToString(), comboHafta.SelectedItem.ToString());
            labelHata.Text = "";
            }
            else
            {
                labelHata.Text = "HATA : Hafta bilgisi seçilmedi veya karşılaşma yoktur.";
            }
        }

        private void btnFiksturSil_Click(object sender, EventArgs e)
        {
            //Lige göre fikstürü siliyoruz
            gozlemcilereHaberVer("FiksturSil", comboLig.SelectedItem.ToString(), comboLig.SelectedItem.ToString());
        }

        //fikstur oluşturmak için hazırlıklar yapılıyor
        private string fiksturSartlariSaglandimi()
        {
            int takimSayisi = fkcon.takimlariCek(islemYapilanLig).Count;
            int salonSayisi = fkcon.salonlariCek(islemYapilanLig).Count;
            int hakemSayisi = ligeGoreHakemCek(islemYapilanLig).Count;
            string str = "";
            if (takimSayisi % 2 == 0) //takım sayısı çift sayıda mı
            { 
                if (takimSayisi / 2 <= salonSayisi)  // takımların yarısı kadar salon var mı
                {
                    if (takimSayisi <= hakemSayisi)  // sahada en az iki hakem olmalı şartı
                    {
                        str = "Evet";
                    }
                    else{str = " Hakem sayısı yeterli değil.";}                        
                }
                else{str = " Salon sayısı yeterli değil.";}                  
            }
            else{str = " Takım sayısı çift değil.";}

            return str;
        }

        private void comboLig_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //comboboxtan seçilen ligin takım sayısı ile haftaları oluşturuyoruz ve hafta comboboxına atıyoruz
            islemYapilanLig=comboLig.SelectedItem.ToString();
            int takimSayisi = fkcon.takimlariCek(islemYapilanLig).Count;
            List<string> haftalar = haftalariOlustur(takimSayisi);
            comboHafta.DataSource = haftalar;
        }

        private  List<string> haftalariOlustur(int takimSayisi)
        {
            List<string> haftalar = new List<string>();
            for (int i = 0; i < (takimSayisi - 1) * 2; i++)
            {
                haftalar.Add((i + 1) + ".Hafta");
            }
            return haftalar;
        }

        private  List<string> gunleriOlustur(List<string> haftalist,DateTimePicker dtp)
        {
            List<string> gunler = new List<string>();
            DateTime dt = DateTime.Parse(dtp.Value.ToString("dd/MM/yyyy"));           
            for (int i = 0; i < haftalist.Count ; i++)
            {                
                gunler.Add(dt.ToShortDateString());
                dt = gunEkle(dt,1.0);
                gunler.Add(dt.ToShortDateString());
                dt = gunEkle(dt,6.0);
            }
            return gunler;
        }
        
        private DateTime gunEkle(DateTime dt, double gun)
        {
            return dt.AddDays(gun);
        }

        //fikstur oluşturulmaya başlanıyor
        private void fiksturOlustur()
        {
            List<Takim> takimListesi = fkcon.takimlariCek(islemYapilanLig);
            int takimSayisi = takimListesi.Count;
            List<string> haftaListesi=haftalariOlustur(takimSayisi);
            List<string> gunListesi = gunleriOlustur(haftaListesi, dtpFiksturBaslangic);
            List<Fikstur> fiksturListesi = new List<Fikstur>();            
            List<int> rastgeleTakimListesi = rastgeleTakimListesiOlustur(takimSayisi);
            List<Hakem> hakemlistesi = ligeGoreHakemCek(islemYapilanLig);
            List<int> rastgeleHakemListesi=rastgeleHakemListesiOlustur(hakemlistesi.Count);
            
            //haftalar
            for (int i=0; i < (takimSayisi - 1) * 2; i++)
            {
                //karşılaşmalar  // j takım ve hakem seçerken ikişer tane seçiyoruz oyuzden ikişer artıyor
                for (int j = 0; j < takimSayisi; j+=2)
                {
                    Fikstur fks = new Fikstur();                    
                    karsilasmayaGunAta(fks,j,i,takimSayisi,gunListesi);
                    karsilasmayaSaatAta(fks, j, takimSayisi);
                    fiksturTakimSalonLigHaftaAta(haftaListesi, takimListesi, rastgeleTakimListesi, i, j, fks);
                    karsilasmayaHakemAta(fks, hakemlistesi, j, rastgeleHakemListesi);
                    fiksturListesi.Add(fks);
                }
                listeyiKaydir(rastgeleTakimListesi);  //rastgele listesinde kaydırma yapıyoruz 
            }
            gozlemcilereHaberVer("FiksturKaydet", fiksturListesi,islemYapilanLig);//kayıt işlemini yaptırıyoruz
        }

        private void fiksturTakimSalonLigHaftaAta(List<string> haftaListesi, List<Takim> takimListesi, List<int> rastgeleTakimListesi, int i, int j, Fikstur fks)
        {
            //rastgele sayı listesine göre takim listesinden takim seçiyoruz
            Takim tkm1 = takimListesi.ElementAt(rastgeleTakimListesi.ElementAt(j));
            Takim tkm2 = takimListesi.ElementAt(rastgeleTakimListesi.ElementAt(j+1));

            fks.fikstur_takim1 = tkm1.takim_adi;
            fks.fikstur_takim2 = tkm2.takim_adi;
            fks.fikstur_salon = tkm1.takim_salon;
            fks.fikstur_lig = islemYapilanLig;
            fks.fikstur_hafta = haftaListesi.ElementAt(i);
        }

        private void karsilasmayaGunAta(Fikstur fks, int j, int i, int tsayi, List<string> gunListe)
        {
            if ( j < tsayi /2)
            {
                fks.fikstur_gun = gunListe.ElementAt(i*2);
            }
            else{
                fks.fikstur_gun = gunListe.ElementAt((i*2)+1);
            }
        }

        private void karsilasmayaSaatAta(Fikstur fks,int j,int tsayi)
        {
            if (j < tsayi / 2)
            {
                fks.fikstur_saat = "15:00";
            }
            else
            {
                fks.fikstur_saat = "17:00";
            }
        }

        private List<int> rastgeleTakimListesiOlustur(int tsayi)
        {
            Random rnd = new Random();
            List<int> rndListe = new List<int>();
            for (int i = 0; i < tsayi; i++)
            {
                while (true)
                {
                    int rndsayi=rnd.Next(tsayi);
                    if (!rndListe.Contains(rndsayi))
                    {
                        rndListe.Add(rndsayi);
                        break;
                    }
                }
            }
            return rndListe;
        }

        private void listeyiKaydir(List<int> liste)
        {
            int tmpsayi = liste.ElementAt(1);
            liste.Remove(tmpsayi);
            liste.Add(tmpsayi);
        }

        private void karsilasmayaHakemAta(Fikstur fks, List<Hakem> hakemlistesi, int j, List<int> rastgeleHakemListesi)
        {
            j = rastgeleHakemListesi.ElementAt(j);
            string str= hakemlistesi.ElementAt(j).hakem_adi + " " + hakemlistesi.ElementAt(j).hakem_soyadi + " - " ;
            bool ikinciHakemEklendi = true;                   
            for(int i = 0 ; i < hakemlistesi.Count(); i++)
            {
                // kendisi dışında aynı grupta adam varmı 
                if (hakemlistesi.ElementAt(j).hakem_grup.Equals(hakemlistesi.ElementAt(i).hakem_grup) &&
                   hakemlistesi.ElementAt(j).hakem_id != hakemlistesi.ElementAt(i).hakem_id)
                {
                    str += hakemlistesi.ElementAt(i).hakem_adi + " " + hakemlistesi.ElementAt(i).hakem_soyadi ;
                    ikinciHakemEklendi = false;
                }
                
            }
            if (ikinciHakemEklendi)
            {
                //aynı grupta hakem yoksa ensondaki hakem atanır
                int indis = rastgeleHakemListesi.ElementAt(rastgeleHakemListesi.Count);
                str += hakemlistesi.ElementAt(indis).hakem_adi + " " +
                    hakemlistesi.ElementAt(indis).hakem_soyadi;
            }
            fks.fikstur_hakem = str;
        }
        
        private List<Hakem> ligeGoreHakemCek(string alig)
        {
            string str="A Klasman";
            if (alig.Contains("Süperlig"))
            {
                str = "A Klasman";
            }
            else if (alig.Contains("1. Lig"))
            {
                str = "B Klasman";
            }
            else if (alig.Contains("2. Lig"))
            {
                str = "C Klasman";
            }
          return fkcon.hakemleriCek(str);
        }

        private List<int> rastgeleHakemListesiOlustur(int tsayi)
        {
            Random rnd = new Random();
            List<int> rndListe = new List<int>();
            for (int i = 0; i < tsayi; i++)
            {
                while (true)
                {
                    int rndsayi = rnd.Next(tsayi);
                    if (!rndListe.Contains(rndsayi))
                    {
                        rndListe.Add(rndsayi);
                        break;
                    }
                }
            }
            return rndListe;
        }

     }
}
