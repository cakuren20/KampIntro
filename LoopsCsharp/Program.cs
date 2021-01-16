using System;

namespace LoopsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Geliştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç Temel Kursu";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] { "Yazılımcı Geliştirme Kursu", "Programlamaya Başlangıç Temel Kursu", "Java Kursu" , "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti, forech başlıyor");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}