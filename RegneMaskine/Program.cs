using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegneMaskine
{
  class Program
  {
    static void Main(string[] args)
    {
      Boolean needsHelp = true;

      do
      {
        int svar = 0;

        Console.Clear();
        Console.WriteLine("1. Plus, Minus, Gange, Dividere");
        Console.WriteLine("2. Gennemsnit, Modulus, Kvadratrod");
        Console.WriteLine("3. Areal");
        Console.WriteLine("4. Omkreds");
        Console.WriteLine("5. Rumfang");
        Console.WriteLine("6. Pythagoras");
        Console.WriteLine("7. Slut");

        try { svar = Convert.ToInt32(Console.ReadLine()); }
        catch (Exception) { Console.Clear(); }

        switch (svar)
        {
          case 1:
            Menu1();
            break;
          case 2:
            Menu2();
            break;
          case 3:
            Menu3();
            break;
          case 4:
            Menu4();
            break;
          case 5:
            Menu5();
            break;
          case 6:
            Menu6();
            break;
          case 7:
            needsHelp = false;
            break;
        }
      } while (needsHelp);
    }

    static void Menu1()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Plus");
      Console.WriteLine("2. Minus");
      Console.WriteLine("3. Gange");
      Console.WriteLine("4. Dividere");
      Console.WriteLine("5. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu1(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Giv mig dit første tal");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig dit andet tal");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} + {var2} = {Plus(var1, var2)}");

          Console.ReadKey();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Giv mig dit første tal");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig dit andet tal");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} - {var2} = {Minus(var1, var2)}");

          Console.ReadKey();
          break;
        case 3:
          Console.Clear();
          Console.WriteLine("Giv mig dit første tal");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig dit andet tal");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} * {var2} = {Gange(var1, var2)}");

          Console.ReadKey();
          break;
        case 4:
          Console.Clear();
          Console.WriteLine("Giv mig dit første tal");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig dit andet tal");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} / {var2} = {Division(var1, var2)}");

          Console.ReadKey();
          break;
        case 5:
          break;
      }
    }

    static void Menu2()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Gennemsnit");
      Console.WriteLine("2. Modulus");
      Console.WriteLine("3. Kvadratrod");
      Console.WriteLine("4. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu2(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Hvor mange tal har du?");

          int arrStr = Convert.ToInt32(Console.ReadLine());
          double[] var = new double[arrStr];

          Console.Clear();
          Console.WriteLine($"Giv mig {arrStr} tal");

          for (int i = 0; i < arrStr; i++)
          {
            var[i] = Convert.ToDouble(Console.ReadLine());
          }

          Console.Clear();
          Console.WriteLine($"{Gennemsnit(var)}");

          Console.ReadKey();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Giv mig dit første tal");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig dit andet tal");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} % {var2} = {Modulus(var1, var2)}");

          Console.ReadKey();
          break;
        case 3:
          Console.Clear();
          Console.WriteLine("Giv mig et tal");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"Kvadratroden af {var1} = {Kvadratrod(var1)}");

          Console.ReadKey();
          break;
        case 4:
          break;
      }
    }

    static void Menu3()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Areal af Retvinklet Trekant");
      Console.WriteLine("2. Areal af Rektangel");
      Console.WriteLine("3. Areal af Cirkel");
      Console.WriteLine("4. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu3(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Giv mig længden");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig bredten");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} * {var2} / 2 = {ArealRetvinkletTrekant(var1, var2)}");

          Console.ReadKey();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Giv mig længden");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig bredten");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} * {var2} = {ArealRektangel(var1, var2)}");

          Console.ReadKey();
          break;
        case 3:
          Console.Clear();
          Console.WriteLine("Giv mig radiusen");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"3.14 * {var1}^2 = {ArealCirkel(var1)}");

          Console.ReadKey();
          break;
        case 4:
          break;
      }
    }

    static void Menu4()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Omkreds af Retvinklet Trekant");
      Console.WriteLine("2. Omkreds af Rektangel");
      Console.WriteLine("3. Omkreds af Cirkel med Radius");
      Console.WriteLine("4. Omkreds af Cirkel med Diameter");
      Console.WriteLine("5. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu4(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Giv mig a længden");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig b længden");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig c længden");
          double var3 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} + {var2} + {var3} = {OmkredsRetvinkleTrekant(var1, var2, var3)}");

          Console.ReadKey();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Giv mig længden");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig bredten");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"({var1} * 2) + ({var2} * 2) = {OmkredsRektangel(var1, var2)}");

          Console.ReadKey();
          break;
        case 3:
          Console.Clear();
          Console.WriteLine("Giv mig radiusen");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"2 * {var1} * 3.14 = {OmkredsCirkelMedRadius(var1)}");

          Console.ReadKey();
          break;
        case 4:
          Console.Clear();
          Console.WriteLine("Giv mig diameteren");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1} * 3.14 = {OmkredsCirkelMedDiameter(var1)}");

          Console.ReadKey();
          break;
        case 5:
          break;
      }
    }

    static void Menu5()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Rumfang af Retvinklet Cylinder");
      Console.WriteLine("2. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu5(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Giv mig radius");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig højden");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"3.14 * {var1}^2 * {var2} = {RumfangAfRetvinkletCylinder(var1, var2)}");

          Console.ReadKey();
          break;
        case 2:
          break;
      }
    }

    static void Menu6()
    {
      Console.Clear();
      int svar = 0;
      Console.WriteLine("1. Pythagoras find a");
      Console.WriteLine("2. Pythagoras find b");
      Console.WriteLine("3. Pythagoras find c");
      Console.WriteLine("4. Tilbage");

      try { svar = Convert.ToInt32(Console.ReadLine()); }
      catch (Exception) { Console.Clear(); Menu6(); }

      switch (svar)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("Giv mig c længden");
          double var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig b længden");
          double var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1}^2 - {var2}^2 = {PythagorasFindA(var1, var2)}");

          Console.ReadKey();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Giv mig c længden");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig a længden");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1}^2 - {var2}^2 = {PythagorasFindB(var1, var2)}");

          Console.ReadKey();
          break;
        case 3:
          Console.Clear();
          Console.WriteLine("Giv mig a længden");
          var1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Giv mig b længden");
          var2 = Convert.ToDouble(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{var1}^2 - {var2}^2 = {PythagorasFindC(var1, var2)}");

          Console.ReadKey();
          break;
        case 4:
          break;
      }
    }

    static double Plus(double var1, double var2)
    {
      return var1 + var2;
    }

    static double Minus(double var1, double var2)
    {
      return var1 - var2;
    }

    static double Division(double var1, double var2)
    {
      return var1 / var2;
    }

    static double Gange(double var1, double var2)
    {
      return var1 * var2;
    }

    static double Gennemsnit(double[] var)
    {
      double total = 0;
      for (int i = 0; i < var.Length; i++)
      {
        total += var[i];
      }
      return (total / var.Length);
    }

    static double Modulus(double var1, double var2)
    {
      return var1 % var2;
    }

    static double Kvadratrod(double var)
    {
      return Math.Sqrt(var);
    }

    static double ArealRetvinkletTrekant(double længde, double bredte)
    {
      return (længde * bredte) / 2;
    }

    static double ArealRektangel(double længde, double bredte)
    {
      return længde * bredte;
    }

    static double ArealCirkel(double radius)
    {
      return 3.14 * (Math.Pow(radius, 2));
    }

    static double OmkredsRetvinkleTrekant(double a, double b, double c)
    {
      return a + b + c;
    }

    static double OmkredsRektangel(double længde, double bredte)
    {
      return (længde * 2) + (bredte * 2);
    }

    static double OmkredsCirkelMedRadius(double radius)
    {
      return 2 * radius * 3.14;
    }

    static double OmkredsCirkelMedDiameter(double diameter)
    {
      return diameter * 3.14;
    }

    static double RumfangAfRetvinkletCylinder(double radius, double højde)
    {
      return 3.14 * (Math.Pow(radius, 2)) * højde;
    }

    static double PythagorasFindC(double a, double b)
    {
      return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
    }

    static double PythagorasFindB(double c, double a)
    {
      return Math.Sqrt((Math.Pow(c, 2) - Math.Pow(a, 2)));
    }

    static double PythagorasFindA(double c, double b)
    {
      return Math.Sqrt((Math.Pow(c, 2) - Math.Pow(b, 2)));
    }
  }
}
