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

    public string SplitArray()
    {
      string[] test = _sentence.Split();
      return string.Join(" ", test);
    }
    public string FindAndReplace()
    {
      string[] test = _sentence.Split();

      Console.WriteLine(test.Length);
      for(int i = 0; i <= test.Length - 1; i++)
      {
        if(test[i] == _word)
        {
          Console.WriteLine("TEST!");
          test[i] = _replace;
        }
      }
        Console.WriteLine(test[1]);
      return string.Join(" ", test);
    }
  }
}
