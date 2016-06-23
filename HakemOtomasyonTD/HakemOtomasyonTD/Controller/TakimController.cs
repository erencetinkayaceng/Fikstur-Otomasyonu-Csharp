using HakemOtomasyonTD.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Controller
{
    class TakimController
    {
        private Logger log;

        public TakimController()
        {
            log = Logger.loggerGetir();
        }

        public void yeniTakimKaydet(Takim t)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {               
                db.Takimlar.Add(t);
                db.SaveChanges();
                log.islemiLogla("Ekleme: " + t.takim_adi + " takımı eklendi.");
            }
        }

        public List<Takim> takimlariCek()
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Takimlar.ToList();
                return liste;
            }
        }

        public List<Takim> takimlariHizala(string txt)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<Takim>();
                if (txt.Equals("İsim"))
                    liste = db.Takimlar.OrderBy(x => x.takim_adi).ToList();
                else if (txt.Equals("Sehir"))
                    liste = db.Takimlar.OrderBy(x => x.takim_sehir).ToList();
                else if (txt.Equals("Lig"))
                    liste = db.Takimlar.OrderBy(x => x.takim_ligi).ToList();
                else if (txt.Equals("Salon"))
                    liste = db.Takimlar.OrderBy(x => x.takim_salon).ToList();

                return liste;
            }
        }

        public List<SporSalonu> salonlariCek()
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.SporSalonlari.ToList();
                return liste;
            }
        }

        public void takimSil(int tid)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                Takim geciciTkm = db.Takimlar.SingleOrDefault(tkm => tkm.takim_id == tid);
                string geciciTkmAdi = geciciTkm.takim_adi;
                db.Takimlar.Remove(geciciTkm);
                db.SaveChanges();
                log.islemiLogla("Silme: " + geciciTkmAdi + " takımı sistemden silindi.");
            }

        }

        public List<Takim> takimlardaAramaYap(string aramaTuru, string arananKelime)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<Takim>();
                if (aramaTuru.Equals("İsim"))
                    liste = db.Takimlar.Where(tkm => tkm.takim_adi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Lig"))
                    liste = db.Takimlar.Where(tkm => tkm.takim_ligi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Sehir"))
                    liste = db.Takimlar.Where(tkm => tkm.takim_sehir.StartsWith(arananKelime)).ToList();

                return liste;
            }

        }

        public void takimGuncelle(Takim localtkm)
        {

            using (var db = new HakemOtomasyonDBEntities())
            {
                Takim geciciTkm = db.Takimlar.SingleOrDefault(tkm => tkm.takim_id == localtkm.takim_id);

                geciciTkm.takim_adi = localtkm.takim_adi;
                geciciTkm.takim_sehir = localtkm.takim_sehir;
                geciciTkm.takim_ligi = localtkm.takim_ligi;
                geciciTkm.takim_salon = localtkm.takim_salon;
                geciciTkm.takim_diger = localtkm.takim_diger;
                                
                db.SaveChanges();

                log.islemiLogla("Güncelleme: " + localtkm.takim_adi + " takım bilgileri güncellendi.");
            }

        }
    }
}
