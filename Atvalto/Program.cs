//©KozRom
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//©KozRom
namespace Atvalto
{
  class Program
  {
    //©KozRom
    static string hexa = String.Empty;
    static void Main(string[] args)
    {
      bool nemjo = false;
      do
      {
        Console.Write("Kérek egy hexadecimális számot: ");
        nemjo = false;
        hexa = Console.ReadLine();
        hexa = hexa.ToUpper();
        if (hexa == "")
        {
          nemjo = true;
        }
        foreach (var v in hexa)
        {
          if (v > 'F' || v < 'A' && v > '9' || v < '0')
          {
            nemjo = true;
          }
        }
      } while (nemjo);
      //©KozRom
      List<double> x = new List<double>();
      double osszeg = 0;
      for (int i = 0; i < hexa.Length; i++)
      {
        x.Add(Convert.ToChar(hexa.ToString().Substring(i, 1)));
        if (x[i] >= 65 && x[i] <= 70)
        {
          x[i] -= 55;
        }
        else if (x[i] >= 48 && x[i] <= 57)
        {
          x[i] -= 48;
        }
      }
      x.Reverse();
      for (int i = 0; i < hexa.Length; i++)
      {
        osszeg += x[i] * Math.Pow(16, i);
      }
      Console.WriteLine(osszeg);
      Console.ReadKey();
      //©KozRom
    }
  }
}
//©KozRom
