using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
  class Program
  {
    public static void removeElements(List<int> list, int current, int n)
    {
      if (list.Count != 1)
      {
        int removeIndex = current + n - 1;
        if (removeIndex >= list.Count)
        {
          removeIndex = removeIndex - list.Count;
        }

        

        list.RemoveAt(removeIndex);
        removeElements(list, removeIndex, n);
      }
    }

    public static void removeEveryNth(List<int> list, int n)
    {
      removeElements(list, 0, n);
    }


    static void Main(string[] args)
    {
      int kiekVyru;
      List<int> vyruSarasas = new List<int>();
      int kasKelinta;

      Console.WriteLine("Input:");
      kiekVyru = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Kas kelintas mirsta?");
      kasKelinta = Convert.ToInt32(Console.ReadLine());

      while (kiekVyru > 0)
      {
        vyruSarasas.Add(kiekVyru);
        kiekVyru--;
      }

      vyruSarasas.Reverse();
      removeEveryNth(vyruSarasas, kasKelinta);

      Console.WriteLine("Output:");
      Console.WriteLine(vyruSarasas[0].ToString());
      Console.ReadLine();
    }
  }
}
