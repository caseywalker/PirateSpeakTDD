using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateSpeakTDD
{
  public class WordTranslator
  {
    public List<string> Translate(string wordToTest, List<string> listToTranslate)
    {
      var filteredResults = new List<string>();
      var wordToArr = wordToTest.ToCharArray();
      var orderedArr = wordToArr.OrderBy(c => c);

      foreach(var word in listToTranslate)
      {
        var testWordToArr = word.ToCharArray();
        var orderedTestArr = testWordToArr.OrderBy(b => b);

        if (orderedArr.SequenceEqual(orderedTestArr))
        {
          filteredResults.Add(word);
        }
      }

      return filteredResults;
    }
  }
}
