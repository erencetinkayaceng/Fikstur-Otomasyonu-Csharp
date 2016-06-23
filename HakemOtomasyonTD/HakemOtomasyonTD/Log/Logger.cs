using HakemOtomasyonTD.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Log
{
    class Logger:IGozleyen
    {
        private static Logger _log;
        private const string dosyaYolu = "sistem.log";

        private Logger()
        {
            if (!File.Exists("sistem.log"))
            {
                FileStream fs = File.Create(dosyaYolu);
                fs.Close();
            }
        }

        private static Logger nesneAl
        {
            get
            {
                if (_log == null)
                {
                    _log = new Logger();
                }
                return _log;

            }
            set
            {
                _log = value;
            }

        }
        
        public static Logger loggerGetir()
        {
            return nesneAl;
        }

        public void islemiLogla(string logMetni)
        {
            string zaman = DateTime.Now.ToString("yyyy.MM.dd HH:mm");
            StreamWriter SW = File.AppendText(dosyaYolu);
            SW.WriteLine(zaman+" "+logMetni);
            SW.Close();
        }

        public void guncelle(string operasyon, object obje, string islemYapilanLig)
        {
            if (operasyon.Equals("FiksturKaydet"))
            {
                islemiLogla(islemYapilanLig + " ligi fikstürü oluşturuldu.");
            }
            else if (operasyon.Equals("FiksturSil"))
            {
                islemiLogla(islemYapilanLig + " liginin fikstürü silindi.");
            }
        }
    }
}
