using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeakTDD.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void the_word_to_translate_into_possible_words()
    {
      //Arrange
      var stringToTest = "ortsp";

      var listToTest = new List<string>
      {
        "sport", "parrot", "ports", "matey"
      };

      var expectedList = new List<string>
      {
        "sport", "ports",
      };

      var translator = new WordTranslator();

      //Act
      var actualResult = translator.Translate(stringToTest, listToTest);

      //Assert
      Assert.Equal(expectedList, actualResult);

    }

  }
}
