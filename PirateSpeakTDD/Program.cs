using System;
using System.Linq;

namespace PirateSpeakTDD
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var test = "ortsp";

      var testArr = test.ToCharArray();
      var ordered1 = testArr.OrderBy(c => c);

      var test2 = "sport";

      var test2Arr = test.ToCharArray();
      var ordered2 = test2Arr.OrderBy(c => c);

      var testToWrite = ordered1.SequenceEqual(ordered2);

      Console.WriteLine(testToWrite);
    }
  }
}
