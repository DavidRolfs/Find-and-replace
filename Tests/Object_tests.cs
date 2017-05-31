using Xunit;
using System;
using System.Collections.Generic;

namespace FindAndReplace
{
  public class FindAndReplaceObjects
  {
    [Fact]
    public void Get_userInputSentence_helloworld()
    {
      Object newObject = new Object("Hello World!", "World!", "Universe");
      Assert.Equal("Hello World!", newObject.GetSentence());
    }
    [Fact]
    public void Get_SentenceSplit_array()
    {
      Object newObject = new Object("Hello World!", "World!", "Universe");
      Assert.Equal(2, newObject.SplitArray());
    }
  }
}
