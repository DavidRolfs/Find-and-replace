using Nancy;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace FindAndReplace
{
  public class Object
  {
    private string _sentence;
    private string _word;
    private string _replace;

    public Object(string sentence, string word, string replace)
    {
      _sentence = sentence;
      _word = word;
      _replace = replace;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public int SplitArray()
    {
      string[] test = _sentence.Split();
      Console.WriteLine(test[1]);
      return test.Length;
    }
  }
}
