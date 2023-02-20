using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KullaniciModel
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? MusteriID { get; set; }
        public int? PersonelID { get; set; }
        public int? YoneticiID { get; set; }


    }
}
