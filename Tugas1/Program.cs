using System;

namespace Tugas1
{
  class Program
  { 
    static void Main(string[] args)
    {
      Mobil Mobil = new Mobil();
      Xenia Xenia = new Xenia();
      Console.WriteLine(Mobil.jenis + Xenia.ModelMobil + " mau lewat");
      Xenia.Klakson();
      Xenia.Maju();
    }
  }
}
