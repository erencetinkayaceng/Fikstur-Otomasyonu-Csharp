using HakemOtomasyonTD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Controller
{
    class FiksturController : IGozleyen
    {
        public FiksturController()
        {

        }

        public List<Takim> takimlariCek(string alig)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Takimlar.Where(tkm => tkm.takim_ligi.Contains(alig)).ToList();
                return liste;
            }
        }

        public List<SporSalonu> salonlariCek(string alig)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.SporSalonlari.Where(sln => sln.salon_ligi.Contains(alig)).ToList();
                return liste;
            }
        }

        public List<Hakem> hakemleriCek(string klasman)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Hakemler.Where(hkm => hkm.hakem_klasman.Contains(klasman)).ToList();
                return liste;
            }
        }

        public List<Fikstur> fiksturCek(string alig,string hafta)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Fiksturler.Where(fks => fks.fikstur_lig.StartsWith(alig)).Where(fks => fks.fikstur_hafta.StartsWith(hafta)).ToList();
                return liste;
            }
        }

        public void yeniFiksturKaydet(List<Fikstur> fiksturListe)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {    
                foreach(Fikstur eleman in fiksturListe){
                    db.Fiksturler.Add(eleman);                    
                }
                db.SaveChanges();
            }
        }

        public void fiksturSil(string alig)
        {
            using (var db = new HakemOtomasyonDBEntities())
            {
                var liste = db.Fiksturler.Where(fks => fks.fikstur_lig.Contains(alig)).ToList();
                foreach (Fikstur eleman in liste)
                {
                    db.Fiksturler.Remove(eleman);
                }                 
                db.SaveChanges();
            }
        }

        public void guncelle(string operasyon, object obje, string islemYapilanLig)
        {
            if (operasyon.Equals("FiksturKaydet"))
            {
                yeniFiksturKaydet((List<Fikstur>)obje);
            }
            else if (operasyon.Equals("FiksturSil"))
            {
                fiksturSil((string)obje);
            }
        }
    }
}
