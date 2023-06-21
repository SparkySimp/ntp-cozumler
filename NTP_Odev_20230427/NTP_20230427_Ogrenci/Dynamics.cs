using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using System.Diagnostics;

namespace NTP_20230427_Ogrenci
{
    /// <summary>
    /// Represents the dynamic resource host for the project.
    /// </summary>
    internal static class Dynamics
    {
        private static readonly List<Ogretmen> ogretmens = new List<Ogretmen>();
        public static List<Ogretmen> Ogretmenler = ogretmens;
        private static readonly List<Ogrenci> ogrencis = new List<Ogrenci>();
        public static List<Ogrenci> Ogrenciler = ogrencis;
        public static readonly string[] BRANCHES =
        {
            "Beden Eğitimi ve Spor",
            "Biyoloji",
            "Coğrafya",
            "Din Kültürü ve Ahlâk Bilgisi",
            "Felsefe",
            "Fizik",
            "Kimya",
            "Matematik",
            "Nesne Tabanlı Programlama",
            "Ağ Sistemleri ve Anahtarlama",
            "Robotik Kodlama",
            "Tarih",
            "Türk Dili ve Edebiyatı",
            "Yabancı Dil",
        };
        public static Random prng = new Random();

        public static void SaveProgramState()
        {
            string str = JsonConvert.SerializeObject(new { Ogretmenler, Ogrenciler });
            DirectoryInfo diStateDir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "studentmgr"));
            try
            {
                if (!diStateDir.Exists) diStateDir.Create();
                var fs = new StreamWriter(File.OpenWrite(Path.Combine(diStateDir.FullName, "student.json")));
                fs.BaseStream.Seek(0, SeekOrigin.Begin); // Overwrite the file.
                fs.WriteLine(str);
                fs.Close();
            }
            catch (IOException)
            {
                Debug.WriteLine($"Failed to save state.");
                // throw;
            }
            
        }

        public static void LoadProgramState()
        {
            try
            {
                FileInfo fiState = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "studentmgr", "student.json"));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
