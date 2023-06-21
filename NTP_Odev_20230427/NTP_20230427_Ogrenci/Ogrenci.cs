using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_20230427_Ogrenci
{
    /// <summary>
    /// Bir öğrenciyi temsil eder.
    /// </summary>
    class Ogrenci : Insan
    {
        /// <summary>
        /// Okul numarası
        /// </summary>
        public int OkulNo { get; set; }

        /// <summary>
        /// Öğrencinin girdiği dersler.
        /// </summary>
        public List<string> GirilenDersler { get; set; }

        /// <summary>
        /// Öğrencinin dersten alıdğı notlar.
        /// </summary>
        public Dictionary<string, double[]> Notlar { get; set; }
    }
}
