using HakemOtomasyonTD.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Controller
{
    class HakemController
    {
        private Logger log;

        public HakemController()
        {
            log = Logger.loggerGetir();
        }

        public void yeniHakemKaydet(Hakem h)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {                
                db.Hakemler.Add(h);
                db.SaveChanges();
                log.islemiLogla("Ekleme: Hakem " + h.hakem_adi + " eklendi.");
            }
        }

        public List<Hakem> hakemleriCek()
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Hakemler.ToList();
                return liste;
            }
        }

        public List<string> hakemGruplariniCek()
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Hakemler.Select(x => x.hakem_grup).Distinct().ToList();
                return liste;
            }
        }

        public List<Hakem> hakemleriHizala(string txt)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<Hakem>();
                if (txt.Equals("Ad"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_adi).ToList();
                else if (txt.Equals("Soyad"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_soyadi).ToList();
                else if (txt.Equals("Tür"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_tur).ToList();
                else if (txt.Equals("Klasman"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_klasman).ToList();
                else if (txt.Equals("Bölge"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_bolge).ToList();
                else if (txt.Equals("Grup"))
                    liste = db.Hakemler.OrderBy(x => x.hakem_grup).ToList();

                return liste;
            }
        }

        public void hakemSil(int hid)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                Hakem geciciHkm = db.Hakemler.SingleOrDefault(hkm => hkm.hakem_id == hid);
                string geciciHkmAdi = geciciHkm.hakem_adi;
                db.Hakemler.Remove(geciciHkm);
                db.SaveChanges();
                log.islemiLogla("Silme: Hakem " + geciciHkmAdi + " sistemden silindi.");
            }

        }

        public List<Hakem> hakemlerdeAramaYap(string aramaTuru, string arananKelime)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<Hakem>();
                if (aramaTuru.Equals("Ad"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_adi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Soyad"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_soyadi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Tür"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_tur.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Klasman"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_klasman.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Bölge"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_bolge.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Grup"))
                    liste = db.Hakemler.Where(tkm => tkm.hakem_grup.StartsWith(arananKelime)).ToList();
                return liste;
            }

        }

        public void hakemGuncelle(Hakem localhkm)
        {

            using (var db = new HakemOtomasyonDBEntities())
            {
                Hakem geciciHkm = db.Hakemler.SingleOrDefault(hkm => hkm.hakem_id == localhkm.hakem_id);
                
                geciciHkm.hakem_adi = localhkm.hakem_adi;
                geciciHkm.hakem_soyadi = localhkm.hakem_soyadi;
                geciciHkm.hakem_tur = localhkm.hakem_tur;
                geciciHkm.hakem_klasman = localhkm.hakem_klasman;
                geciciHkm.hakem_bolge = localhkm.hakem_bolge;
                geciciHkm.hakem_grup = localhkm.hakem_grup;
                               
                db.SaveChanges();
                log.islemiLogla("Güncelleme: Hakem " + localhkm.hakem_adi + " bilgileri güncellendi.");
            }

        }
    }
}
