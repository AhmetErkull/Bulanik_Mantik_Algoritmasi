using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulanik_Mantik_ODEV
{
    static public class Enumlar
    {
        public enum Hassaslik
        {
            Saglam,
            Orta,
            Hassas
        }
        public enum Miktar
        {
            Kucuk,
            Orta,
            Buyuk
        }

         public enum Kirlilik
        {
            Kucuk,
            Orta,
            Buyuk
        }
        public enum Deterjan_Miktari
        {
            Cok_Az,
            Az,
            Orta,
            Fazla,
            Cok_Fazla
        }
        public enum Sure
        {
            Kisa,
            Normal_Kisa,
            Orta,
            Normal_Uzun,
            Uzun
        }
        public enum DonusHizi
        {
            Hassas,
            Normal_Hassas,
            Orta,
            Normal_Guclu,
            Guclu
        }
    }
}
