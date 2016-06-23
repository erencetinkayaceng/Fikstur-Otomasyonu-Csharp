using HakemOtomasyonTD.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Controller
{
    class SalonController
    {
        private Logger log;

        public SalonController()
        {
            log = Logger.loggerGetir();
        }
        public void yeniSalonKaydet(SporSalonu s)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {              
                db.SporSalonlari.Add(s);
                db.SaveChanges();
                log.islemiLogla("Ekleme: " + s.salon_adi + " spor salonu eklendi.");
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

        public List<SporSalonu> salonlariHizala(string txt)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<SporSalonu>();
                if (txt.Equals("İsim"))
                    liste = db.SporSalonlari.OrderBy(x => x.salon_adi).ToList();
                else if (txt.Equals("Sehir"))
                    liste = db.SporSalonlari.OrderBy(x => x.salon_sehir).ToList();
                else if (txt.Equals("Lig"))
                    liste = db.SporSalonlari.OrderBy(x => x.salon_ligi).ToList();
                return liste;
            }
        }

        public void salonSil(int sid)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                SporSalonu geciciSln = db.SporSalonlari.SingleOrDefault(sln => sln.salon_id == sid);
                string geciciSlnAdi = geciciSln.salon_adi;
                db.SporSalonlari.Remove(geciciSln);
                db.SaveChanges();
                log.islemiLogla("Silme: " + geciciSlnAdi + " spor salonu sistemden silindi.");
            }

        }

        public List<SporSalonu> salonlardaAramaYap(string aramaTuru, string arananKelime)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = new List<SporSalonu>();
                if (aramaTuru.Equals("İsim"))
                    liste = db.SporSalonlari.Where(sln => sln.salon_adi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Lig"))
                    liste = db.SporSalonlari.Where(sln => sln.salon_ligi.StartsWith(arananKelime)).ToList();
                else if (aramaTuru.Equals("Sehir"))
                    liste = db.SporSalonlari.Where(sln => sln.salon_sehir.StartsWith(arananKelime)).ToList();
                return liste;
            }

        }

        public void salonGuncelle(SporSalonu localsln)
        {

            using (var db = new HakemOtomasyonDBEntities())
            {
                SporSalonu geciciSln = db.SporSalonlari.SingleOrDefault(sln => sln.salon_id == localsln.salon_id);

                geciciSln.salon_adi = localsln.salon_adi;
                geciciSln.salon_sehir = localsln.salon_sehir;
                geciciSln.salon_ligi = localsln.salon_ligi;
                geciciSln.salon_diger = localsln.salon_diger;
                               
                db.SaveChanges();
                log.islemiLogla("Güncelleme: " + localsln.salon_adi + " spor salonu bilgileri güncellendi.");
            }

        }
              
    }
}
