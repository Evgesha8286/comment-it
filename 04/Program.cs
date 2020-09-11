using System;

namespace pr2_02_upr2
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
      string[] sa = s.Split(" ");
      Array.Sort(sa);
      s = string.Join(" ", sa); Console.WriteLine(s);
    }
  }
}
