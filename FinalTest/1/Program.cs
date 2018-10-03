using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace First
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> vaikai = new List<string>();
      List<string> vaikuInfo = new List<string>();
      var viskas = File.ReadAllLines("u1.txt");

      int laisvosVietos = Convert.ToInt32(viskas[viskas.Length - 2]);
      int prioritetai = Convert.ToInt32(viskas[viskas.Length - 1]);

      foreach (var eilute in viskas)
      {
        vaikai.Add(eilute);
      }

      vaikai.RemoveAt(vaikai.Count - 1);
      vaikai.RemoveAt(vaikai.Count - 1);

      foreach (var a in vaikai)
      {
        
      }

      if (laisvosVietos > 0)
      {
        
      }

    }
  }
}
