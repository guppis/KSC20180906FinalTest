using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Drawing;

namespace Antra
{
  class Program
  {

    private static string HexFromRGB(int r, int g, int b)
    {
      return ColorTranslator.FromHtml(String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b)).Name.Remove(0, 2);
    }

    static void Main(string[] args)
    {
      
      string[] lines = File.ReadAllLines("U2.txt");
      var sarasas = lines.ToList();
      
      var temp = sarasas[0].Split(' ');
      int rows = Convert.ToInt32(temp[0]);
      int columns = Convert.ToInt32(temp[1]);
      var hexList = new List<string>();
      
      sarasas.RemoveAt(0);

      foreach (var eilute in sarasas)
      {
        var rgb = eilute.Split(' ');
        var r = Convert.ToInt32(rgb[0]);
        var g = Convert.ToInt32(rgb[1]);
        var b = Convert.ToInt32(rgb[2]);
        var hex = HexFromRGB(r, g, b);
        hexList.Add(hex);
      }

      DataTable dt = new DataTable();

      dt.Columns.Add();
      

      for (int i = 0; i < rows; i++)
      {
        var eilutesKodai = hexList.GetRange(0, columns);
        hexList.RemoveRange(0,columns);
        var eilute = String.Join(";", eilutesKodai.ToArray());
        dt.Rows.Add(new Object[] { eilute});

      }
      var stream = new StreamWriter("U2rez.txt");

      foreach (DataRow row in dt.Rows)
      {
        stream.WriteLine(row[0]);
      }
      stream.Close();
    }
  }
}
