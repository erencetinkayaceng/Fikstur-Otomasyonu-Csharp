using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemOtomasyonTD.Interface
{
   public interface IGozlenen
    {
       void gozlemcilereHaberVer(string operasyon, Object obje ,string islemYapilanLig);
        void gozlemciEkle(IGozleyen gozlemci);
        void gozlemciSil(IGozleyen gozlemci);
    }
}
